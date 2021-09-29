using System;
using System.Collections.Generic;
using System.Text;

namespace Desktop
{
    class Ctr_Hospede
    {
        public Mensagem AdicionarHospede(Hospede Hospede)
        {
            //sql insert

            

            Mensagem Mensagem = new Mensagem();
            Mensagem.TMensagem = "Hóspede adicionado com sucesso.";

            return Mensagem;
        }
    }
}
