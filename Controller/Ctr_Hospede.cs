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

                Mensagem.sql = "INSERT INTO HOSPEDES (DOCID,NOME,ENDERECO,TELEFONE,EMAIL,DATANASCIMENTO,NACIONALIDADE,CPF,CIDADE)" 
                    + "VALUES (@DocId, @Nome, @Endereco, @Telefone, @Email, @Nascimento, @Nacionalidade, @Cpf, @Cidade)";

                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@DocId", Hospede.IDPessoa);
                cmd.Parameters.AddWithValue("@Nome", Hospede.NomePessoa);
                cmd.Parameters.AddWithValue("@Endereco", Hospede.EnderecoPessoa);
                cmd.Parameters.AddWithValue("@Telefone", Hospede.TelefonePessoa); //Atribuindos os valores
                cmd.Parameters.AddWithValue("@Email", Hospede.EmailPessoa);
                cmd.Parameters.AddWithValue("@Nascimento", Hospede.NascimentoPessoa);
                cmd.Parameters.AddWithValue("@Nacionalidade", Hospede.Nacionalidade);
                cmd.Parameters.AddWithValue("@Cpf", Hospede.CPFPessoa);
                cmd.Parameters.AddWithValue("@Cidade", Hospede.Cidade);

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
                cmd.Parameters.AddWithValue("@DocId", Hospede.IDPessoa);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Hospede.CPFPessoa = Convert.ToDouble(reader["CPF"]);
                    Hospede.IDPessoa = Convert.ToString(reader["DOCID"]);
                    Hospede.NomePessoa = Convert.ToString(reader["NOME"]);
                    Hospede.EnderecoPessoa = Convert.ToString(reader["ENDERECO"]);
                    Hospede.TelefonePessoa = Convert.ToString(reader["TELEFONE"]);
                    Hospede.EmailPessoa = Convert.ToString(reader["EMAIL"]);
                    Hospede.NascimentoPessoa = Convert.ToDateTime(reader["DATANASCIMENTO"]);
                    Hospede.Nacionalidade = Convert.ToString(reader["NACIONALIDADE"]);
                    Hospede.Cidade = Convert.ToString(reader["CIDADE"]);

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
                Mensagem.sql = "UPDATE HOSPEDES set NOME = @Nome, ENDERECO = @Endereco, TELEFONE = @Telefone, EMAIL = @Email, DATANASCIMENTO = @Nascimento, NACIONALIDADE = @Nacionalidade, CIDADE = @Cidade WHERE CPF = @Cpf";
                cmd = new SqlCommand(Mensagem.sql, con);

                cmd.Parameters.AddWithValue("@DocId", Hospede.IDPessoa);
                cmd.Parameters.AddWithValue("@Nome", Hospede.NomePessoa);
                cmd.Parameters.AddWithValue("@Endereco", Hospede.EnderecoPessoa);
                cmd.Parameters.AddWithValue("@Telefone", Hospede.TelefonePessoa); //Atribuindos os parâmetros com os valores
                cmd.Parameters.AddWithValue("@Email", Hospede.EmailPessoa);
                cmd.Parameters.AddWithValue("@Nascimento", Hospede.NascimentoPessoa);
                cmd.Parameters.AddWithValue("@Nacionalidade", Hospede.Nacionalidade);
                cmd.Parameters.AddWithValue("@Cpf", Hospede.CPFPessoa);
                cmd.Parameters.AddWithValue("@Cidade", Hospede.Cidade);

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
                cmd.Parameters.AddWithValue("@DocId", Hospede.IDPessoa);

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

