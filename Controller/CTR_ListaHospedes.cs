using System;
using System.Collections.Generic;
using System.Text;
using Desktop.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Desktop.Controller
{
    class CTR_ListaHospedes
    {
        SqlCommand cmd;
        SqlDataAdapter DA;
        Credenciais cred = new Credenciais();
        SqlConnection con;
        Mensagem Mensagem = new Mensagem();

        public ListaHospedes PesquisarID(ListaHospedes ListaHospede)
        {
            con = new SqlConnection(cred.constring); //connection string do BD
            try
            {
                con.Open();

                Mensagem.sql = "SELECT * FROM HOSPEDES WHERE DOCID = @DocumentoID";
                cmd = new SqlCommand(Mensagem.sql, con);
                cmd.Parameters.AddWithValue("@DocumentoID", ListaHospede.DocumentoID);

                cmd.CommandType = CommandType.Text;

                DA = new SqlDataAdapter(cmd);

                ListaHospede.Lista = new DataTable();

                DA.Fill(ListaHospede.Lista);
            }

            catch
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados, por favor tente novamente em instantes. Se o problema persistir, entre em contato conosco pelos canais de atendimento.", "Erro: Conexão falhou", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }

            return ListaHospede;
        }


        public ListaHospedes CarregarLista(ListaHospedes ListaHospede)
        {
            con = new SqlConnection(cred.constring); //connection string do BD
            try
            {
                con.Open();
                Mensagem.sql = "SELECT * FROM HOSPEDES";
                cmd = new SqlCommand(Mensagem.sql, con);

                cmd.CommandType = CommandType.Text;

                DA = new SqlDataAdapter(cmd);

                ListaHospede.Lista = new DataTable();

                DA.Fill(ListaHospede.Lista);
            }

            catch
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados, por favor tente novamente em instantes. Se o problema persistir, entre em contato conosco pelos canais de atendimento.", "Erro: Conexão falhou", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }

            return ListaHospede;
        }
    }
}
