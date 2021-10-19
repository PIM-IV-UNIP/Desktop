using System;
using System.Data.SqlClient;
using Desktop.Model;

namespace Desktop.Controller
{
    class CTR_Hospede 
    {
        Mensagem Mensagem = new Mensagem();
        SqlConnection con = new SqlConnection(@"Data Source = utor_\SQLEXPRESS; Initial Catalog = BDCadastro; Integrated Security = True"); //connection string do BD
        SqlCommand cmd;

        public Mensagem AdicionarHospede(Hospede Hospede)
        { 
            try
            {
                con.Open(); //conectando ao BD

                Mensagem.sql = "INSERT INTO dbo.HOSPEDE (HOSPEDEID,NOME,ENDERECO,TELEFONE,EMAIL,DATANASCIMENTO,NACIONALIDADE)"
    + "VALUES (@HospedeID, @Nome, @Endereco, @Telefone, @Email, @Nascimento, @Nacionalidade)";

                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@HospedeID", Hospede.rgPessoa);
                cmd.Parameters.AddWithValue("@Nome", Hospede.nomePessoa);
                cmd.Parameters.AddWithValue("@Endereco", Hospede.enderecoPessoa);
                cmd.Parameters.AddWithValue("@Telefone", Hospede.telefonePessoa); //Atribuindos os parâmetros com os valores
                cmd.Parameters.AddWithValue("@Email", Hospede.emailPessoa);
                cmd.Parameters.AddWithValue("@Nascimento", Hospede.nascimentoPessoa);
                cmd.Parameters.AddWithValue("@Nacionalidade", Hospede.nacionalidade);
                cmd.CommandType = System.Data.CommandType.Text;
                
                Mensagem.teste = cmd.ExecuteNonQuery();
                if (Mensagem.teste > 0)
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
            try
            {
                SqlDataReader reader;

                con.Open();
                Mensagem.sql = "SELECT * FROM dbo.HOSPEDE WHERE HOSPEDEID = @HospedeID";
                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@HospedeID", Hospede.rgPessoa);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Hospede.rgPessoa = Convert.ToDouble(reader["HOSPEDEID"]);
                    Hospede.nomePessoa = Convert.ToString(reader["NOME"]);
                    Hospede.enderecoPessoa = Convert.ToString(reader["ENDERECO"]);
                    Hospede.telefonePessoa = Convert.ToString(reader["TELEFONE"]);
                    Hospede.emailPessoa = Convert.ToString(reader["EMAIL"]);
                    Hospede.nascimentoPessoa = Convert.ToDateTime(reader["DATANASCIMENTO"]);
                    Hospede.nacionalidade = Convert.ToString(reader["NACIONALIDADE"]);

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
            try
            {
                con.Open(); //conectando ao BD
                Mensagem.sql = "UPDATE dbo.HOSPEDE set NOME = @Nome, ENDERECO = @Endereco, TELEFONE = @Telefone, EMAIL = @Email, DATANASCIMENTO = @Nascimento, NACIONALIDADE = @Nacionalidade WHERE HOSPEDEID = @HospedeID";
                cmd = new SqlCommand(Mensagem.sql, con);

                cmd.Parameters.AddWithValue("@HospedeID", Hospede.rgPessoa);
                cmd.Parameters.AddWithValue("@Nome", Hospede.nomePessoa);
                cmd.Parameters.AddWithValue("@Endereco", Hospede.enderecoPessoa);
                cmd.Parameters.AddWithValue("@Telefone", Hospede.telefonePessoa); //Atribuindos os parâmetros com os valores
                cmd.Parameters.AddWithValue("@Email", Hospede.emailPessoa);
                cmd.Parameters.AddWithValue("@Nascimento", Hospede.nascimentoPessoa);
                cmd.Parameters.AddWithValue("@Nacionalidade", Hospede.nacionalidade);
                cmd.CommandType = System.Data.CommandType.Text;

                Mensagem.teste = cmd.ExecuteNonQuery();
                if (Mensagem.teste > 0)
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
            try
            {
                con.Open();
                Mensagem.sql = "DELETE FROM dbo.HOSPEDE WHERE HOSPEDEID = @HospedeID";
                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@HospedeID", Hospede.rgPessoa);

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
