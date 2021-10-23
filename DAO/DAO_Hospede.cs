using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Desktop.Model;
using System.Windows.Forms;


namespace Desktop.DAO
{
    class DAO_Hospede
    { 
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=BDHOTEL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"); //connection string do BD

        public void ConectarBD()
        {
            con.Open(); //abrir a conexão com o BD
        }

        public void DesconectarBD()
        {
            con.Close(); //fecha a conexão com  o BD
        }

    }
}
