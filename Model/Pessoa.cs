 using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Desktop.Model
{
    class Pessoa
    { 
        public string NomePessoa { get; set; }
        public string EmailPessoa { get;  set; }
        public string EnderecoPessoa { get; set; }
        public string TelefonePessoa { get; set; }
        public string IDPessoa { get; set; }
        public DateTime NascimentoPessoa { get; set; }
        public string Nacionalidade { get; set; }
        public string Cidade { get; set; }
        public double CPFPessoa { get; set; }

        public void Limpar()
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            NomePessoa = " ";
            EmailPessoa = " ";
            EnderecoPessoa = " ";
            TelefonePessoa = " ";
            EnderecoPessoa = " ";
            TelefonePessoa = " ";
            IDPessoa = " ";
            NascimentoPessoa = DateTime.ParseExact("01/01/0001","dd/MM/yyyy",ci);
            Nacionalidade = " ";
            Cidade = " ";
            CPFPessoa = 0;

        }
    }
}
