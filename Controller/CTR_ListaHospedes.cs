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
        Credenciais cred = new Credenciais();  //Classe que contém as credenciais de acesso ao servidor do Banco de Dados
        SqlConnection con;
        Mensagem Mensagem = new Mensagem();

        public ListaHospedes PesquisarID(ListaHospedes ListaHospede)
        {
            con = new SqlConnection(cred.constring);
            try
            {
                con.Open(); //Abrindo a conexão com o servidor

                Mensagem.sql = "SELECT * FROM HOSPEDES WHERE DOCID = @DocumentoID"; //Setando o comando SQL

                cmd = new SqlCommand(Mensagem.sql, con);//Executando o comando SQL

                //Atribuindo os valores
                cmd.Parameters.AddWithValue("@DocumentoID", ListaHospede.DocumentoID);

                cmd.CommandType = CommandType.Text;

                DA = new SqlDataAdapter(cmd);

                ListaHospede.Lista = new DataTable();

                DA.Fill(ListaHospede.Lista); //Preenchendo um DataAdapter com o DataTable ListaHospede.Lista
            }

            catch
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados, por favor tente novamente em instantes. Se o problema persistir, entre em contato conosco pelos canais de atendimento.", "Erro: Conexão falhou", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close(); //fechando a conexão com o servidor
            }

            return ListaHospede;
        }


        public ListaHospedes CarregarLista(ListaHospedes ListaHospede)
        {
            con = new SqlConnection(cred.constring);
            try
            {
                con.Open();//Abrindo a conexão com o servidor

                Mensagem.sql = "SELECT * FROM HOSPEDES";//Setando o comando SQL

                cmd = new SqlCommand(Mensagem.sql, con);//Executando o comando SQL

                cmd.CommandType = CommandType.Text;

                DA = new SqlDataAdapter(cmd);

                ListaHospede.Lista = new DataTable();

                DA.Fill(ListaHospede.Lista); //Preenchendo um DataAdapter com o DataTable ListaHospede.Lista
            }

            catch
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados, por favor tente novamente em instantes. Se o problema persistir, entre em contato conosco pelos canais de atendimento.", "Erro: Conexão falhou", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close(); //fechando a conexão com o servidor
            }

            return ListaHospede;
        }
    }
}
