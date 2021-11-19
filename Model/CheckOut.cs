using System;
using System.Collections.Generic;
using System.Text;

namespace Desktop.Model
{
    class CheckOut
    {
        public string NumeroQuarto { get; set; }
        public string Hospedadas { get; set; }
        public DateTime PeriodoInicio { get; set; }
        public DateTime PeriodoFinal { get; set; }
        public decimal Valor { get; set; }
        public double PeriodoTotal { get; set; }
    }
}
