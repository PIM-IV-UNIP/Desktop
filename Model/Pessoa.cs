using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Desktop.Model
{
    class Pessoa
    { 
        public string nomePessoa { get; set; }
        public string emailPessoa { get;  set; }
        public string enderecoPessoa { get; set; }
        public string telefonePessoa { get; set; }
        public double rgPessoa { get; set; }
        public DateTime nascimentoPessoa { get; set; }
        public string nacionalidade { get; set; }
        public string localNascimento { get; set; }
        public double cpfPessoa { get; set; }

        public void Limpar()
        {
            CultureInfo ci = CultureInfo.InvariantCulture;

            nomePessoa = " ";
            emailPessoa = " ";
            enderecoPessoa = " ";
            telefonePessoa = " ";
            enderecoPessoa = " ";
            telefonePessoa = " ";
            rgPessoa = 0;
            nascimentoPessoa = DateTime.ParseExact("01/01/0001","dd/MM/yyyy",ci);
            nacionalidade = " ";
            localNascimento = " ";
            cpfPessoa = 0;

        }
    }
}
