using System;
using System.Collections.Generic;
using System.Text;

namespace Desktop
{
    class Hospede
    {
        protected int idHospede { get; set; }
        private string nomePessoa { get; set; }
        protected string emailPessoa { get; set; }
        protected string enderecoPessoa { get; set; }
        protected double telfonePessoa { get; set; }
        protected double rgPessoa { get; set; }
        protected DateTime nascimentoPessoa { get; set; }
        protected string nacionalidade { get; set; }

        public Hospede()
        {
        }
    }
}
