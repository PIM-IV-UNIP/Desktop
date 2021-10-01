using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;

namespace Desktop
{
    class Ctr_Hospede
    {
        Mensagem Mensagem = new Mensagem();
        SqlConnection con = new SqlConnection(@"Data Source = utor_\SQLEXPRESS; Initial Catalog = BDCadastro; Integrated Security = True"); //connection string do BD
        SqlDataReader reader;

        public Mensagem AdicionarHospede(Hospede Hospede)
        {
            Mensagem.sql = "INSERT INTO dbo.HOSPEDE (HOSPEDEID,NOME,ENDERECO,TELEFONE,EMAIL,DATANASCIMENTO,NACIONALIDADE)"
                + "VALUES (@HospedeID, @Nome, @Endereco, @Telefone, @Email, @Nascimento, @Nacionalidade)";

            
            SqlCommand cmd = new SqlCommand(Mensagem.sql, con);
            cmd.Parameters.AddWithValue("@HospedeID", Hospede.rgPessoa);
            cmd.Parameters.AddWithValue("@Nome", Hospede.nomePessoa);
            cmd.Parameters.AddWithValue("@Endereco", Hospede.enderecoPessoa);
            cmd.Parameters.AddWithValue("@Telefone", Hospede.telefonePessoa); //Atribuindos os parâmetros com os valores
            cmd.Parameters.AddWithValue("@Email", Hospede.emailPessoa);
            cmd.Parameters.AddWithValue("@Nascimento", Hospede.nascimentoPessoa);
            cmd.Parameters.AddWithValue("@Nacionalidade", Hospede.nacionalidade);
            cmd.CommandType = System.Data.CommandType.Text;
            con.Open(); //conectando ao BD

            try
            {
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
                Mensagem.sql = "SELECT * FROM HOSPEDE WHERE HOSPEDEID = @HospedeID";

                SqlCommand cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@HospedeID", Hospede.rgPessoa);

                con.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Hospede.nomePessoa = Convert.ToString(reader["NOME"]);
                    Hospede.enderecoPessoa = Convert.ToString(reader["ENDERECO"]);
                    Hospede.telefonePessoa = Convert.ToString(reader["TELEFONE"]);
                    Hospede.emailPessoa = Convert.ToString(reader["EMAIL"]);
                    Hospede.nascimentoPessoa = Convert.ToDateTime(reader["DATANASCIMENTO"]);
                    Hospede.nacionalidade = Convert.ToString(reader["NACIONALIDADE"]);
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
            //sql alter

            Mensagem.TMensagem = "Dados atualizados com sucesso.";

            return Mensagem;
        }
    }
}
