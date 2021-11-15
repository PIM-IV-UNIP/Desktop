using System;
using System.Data;
using System.Data.SqlClient;
using Desktop.Model;
using Desktop.DAO;

namespace Desktop.Controller
{
    class CTR_Hospede
    {
        Mensagem Mensagem = new Mensagem();
        SqlCommand cmd;
        Credenciais cred = new Credenciais();
        SqlConnection con;

        public Mensagem AdicionarHospede(Hospede Hospede)
        {
            con = new SqlConnection(cred.constring);
            try
            {
                con.Open();

                Mensagem.sql = "INSERT INTO HOSPEDES (DOCID,NOME,ENDERECO,TELEFONE,EMAIL,DATANASCIMENTO,NACIONALIDADE,CPF,LOCALDENASCIMENTO)" 
                    + "VALUES (@DocId, @Nome, @Endereco, @Telefone, @Email, @Nascimento, @Nacionalidade, @Cpf, @Localdenascimento)";

                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@DocId", Hospede.idPessoa);
                cmd.Parameters.AddWithValue("@Nome", Hospede.nomePessoa);
                cmd.Parameters.AddWithValue("@Endereco", Hospede.enderecoPessoa);
                cmd.Parameters.AddWithValue("@Telefone", Hospede.telefonePessoa); //Atribuindos os valores
                cmd.Parameters.AddWithValue("@Email", Hospede.emailPessoa);
                cmd.Parameters.AddWithValue("@Nascimento", Hospede.nascimentoPessoa);
                cmd.Parameters.AddWithValue("@Nacionalidade", Hospede.nacionalidade);
                cmd.Parameters.AddWithValue("@Cpf", Hospede.cpfPessoa);
                cmd.Parameters.AddWithValue("@Localdenascimento", Hospede.localNascimento);

                cmd.CommandType = CommandType.Text;

                Mensagem.verifSQL = cmd.ExecuteNonQuery();
               
                if (Mensagem.verifSQL > 0)
                    Mensagem.TMensagem = "Hóspede adicionado com sucesso.";
            }
            catch (Exception ex)
            {
                Mensagem.TMensagem = ("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close(); //fechando a conexão com o BD
            }

            return Mensagem;
        }

        public Mensagem ConsultarHospede(Hospede Hospede)
        {
            con = new SqlConnection(cred.constring);
            try
            {
                SqlDataReader reader;

                con.Open();
                Mensagem.sql = "SELECT * FROM HOSPEDES WHERE DOCID = @DocId";
                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@DocId", Hospede.idPessoa);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Hospede.cpfPessoa = Convert.ToDouble(reader["CPF"]);
                    Hospede.idPessoa = Convert.ToString(reader["DOCID"]);
                    Hospede.nomePessoa = Convert.ToString(reader["NOME"]);
                    Hospede.enderecoPessoa = Convert.ToString(reader["ENDERECO"]);
                    Hospede.telefonePessoa = Convert.ToString(reader["TELEFONE"]);
                    Hospede.emailPessoa = Convert.ToString(reader["EMAIL"]);
                    Hospede.nascimentoPessoa = Convert.ToDateTime(reader["DATANASCIMENTO"]);
                    Hospede.nacionalidade = Convert.ToString(reader["NACIONALIDADE"]);
                    Hospede.localNascimento = Convert.ToString(reader["LOCALDENASCIMENTO"]);

                    Mensagem.TMensagem = "Dados carregados com sucesso.";
                }
                else
                    Mensagem.TMensagem = "Não foi encontrado um registro com o documento informado.";
            }

            catch (Exception ex)
            {
                Mensagem.TMensagem = "Erro: " + ex.ToString();
            }
            finally
            {
                con.Close();
            }
            return Mensagem;
        }
        public Mensagem AtualizarHospede(Hospede Hospede)
        {
            con = new SqlConnection(cred.constring);
            try
            {
                con.Open(); //conectando ao BD
                Mensagem.sql = "UPDATE HOSPEDES set NOME = @Nome, ENDERECO = @Endereco, TELEFONE = @Telefone, EMAIL = @Email, DATANASCIMENTO = @Nascimento, NACIONALIDADE = @Nacionalidade WHERE CPF = @Cpf";
                cmd = new SqlCommand(Mensagem.sql, con);

                cmd.Parameters.AddWithValue("@DocId", Hospede.idPessoa);
                cmd.Parameters.AddWithValue("@Nome", Hospede.nomePessoa);
                cmd.Parameters.AddWithValue("@Endereco", Hospede.enderecoPessoa);
                cmd.Parameters.AddWithValue("@Telefone", Hospede.telefonePessoa); //Atribuindos os parâmetros com os valores
                cmd.Parameters.AddWithValue("@Email", Hospede.emailPessoa);
                cmd.Parameters.AddWithValue("@Nascimento", Hospede.nascimentoPessoa);
                cmd.Parameters.AddWithValue("@Nacionalidade", Hospede.nacionalidade);
                cmd.Parameters.AddWithValue("@Cpf", Hospede.cpfPessoa);
                cmd.Parameters.AddWithValue("@Localdenascimento", Hospede.localNascimento);

                cmd.CommandType = CommandType.Text;

                Mensagem.verifSQL = cmd.ExecuteNonQuery();
                if (Mensagem.verifSQL > 0)
                    Mensagem.TMensagem = "Dados atualizados com sucesso.";
            }
            catch (Exception ex)
            {
                Mensagem.TMensagem = ("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close(); //fechando a conexão com o BD
            }

            return Mensagem;
        }

        public Mensagem ExcluirHospede(Hospede Hospede)
        {
            con = new SqlConnection(cred.constring);
            try
            {
                con.Open();
                Mensagem.sql = "DELETE FROM HOSPEDES WHERE DOCID = @DocId";
                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@DocId", Hospede.idPessoa);

                Mensagem.verifSQL = cmd.ExecuteNonQuery();

                if (Mensagem.verifSQL > 0)
                    Mensagem.TMensagem = "Registo de Hóspede excluído com sucesso.";
            }
            catch (Exception ex)
            {
                Mensagem.TMensagem = ("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close(); //fechando a conexão com o BD
            }

            return Mensagem;
        }
    }
}

