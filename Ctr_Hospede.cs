using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Desktop
{
    class Ctr_Hospede
    {
        Mensagem Mensagem = new Mensagem();

        public Mensagem AdicionarHospede(Hospede Hospede)
        {
            string sql = "INSERT INTO HOSPEDE (HOSPEDEID,NOME,ENDERECO,TELEFONE,EMAIL,DATANASCIMENTO,NACIONALIDADE)"
                + "VALUES ('" + Hospede.rgPessoa + "', '" + Hospede.nomePessoa + "', '" + Hospede.enderecoPessoa + "', '" + Hospede.telfonePessoa
                + "', '" + Hospede.emailPessoa + "', '" + Hospede.nascimentoPessoa + "', '" + Hospede.nacionalidade + "')";

            SqlConnection con = new SqlConnection(@"DataSource = utor_\SQLEXPRESS; Initial Catalog = BDCadastro; Integrated Security = True");

            Mensagem.TMensagem = "Hóspede adicionado com sucesso.";

            return Mensagem;
        }

        public void ConsultarHospede(Hospede Hospede)
        {
            //sql 
        }

        public Mensagem AtualizarHospede(Hospede Hospede)
        {
            //sql alter

            Mensagem.TMensagem = "Dados atualizados com sucesso.";

            return Mensagem;
        }
    }
}
