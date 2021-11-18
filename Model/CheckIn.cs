using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Desktop.Model
{
    class CheckIn
    {
        public string NumeroQuarto { get; set; }
        public string IdQuarto { get; set; }
        public string AddPessoas { get; set; }
        public string IdPesquisa { get; set; }
        public string NomePesquisa { get; set; }
        public DateTime Chegada { get; set; }
        public DateTime Saida { get; set; }
        public decimal Valor { get; set; }
        public DataTable Lista { get; set; }
    }
}
