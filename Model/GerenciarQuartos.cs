using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Desktop.Model
{
    class GerenciarQuartos
    {
        public string TipoQuarto { get; set; }
        public int NumeroQuarto { get; set; }
        public string Validar { get; set; }
        public DataTable Lista { get; set; }
    }
}
