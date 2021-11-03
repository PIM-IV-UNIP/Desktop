using System;
using System.Collections.Generic;
using System.Text;

namespace Desktop.Model
{
    class Credenciais
    {
        public static string user = "sqlserver";
        public static string senha = "pim4semestre";
        public readonly string constring = $@"Data Source=35.198.4.184;Initial Catalog=BDHOTEL;User ID={user};Password={senha};Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
