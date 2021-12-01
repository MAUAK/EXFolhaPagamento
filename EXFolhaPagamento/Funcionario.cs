using System;
using System.Collections.Generic;
using System.Text;

namespace Folha_de_Pagamento
{
    class Funcionario
    {
        //Criando a variavel nome com encapsulamento
        public string Nome { get; set; }
        //Criando a variavel salario com encapsulamento
        public double HorasTrabalhas { get; set; }
        public double ValorPorHora { get; set; }

        public double PagamentoTotal { get; set; }

        /*public Funcionario(string nome, double horastrabalhadas, double valorporhora)
        {
            Nome = nome;
            HorasTrabalhas = horastrabalhadas;
            ValorPorHora = valorporhora;
        }*/

        //Criando o método para incrementar a porcentagem ao salario
        //public abstract double SalarioTotal();

        public void Salario()
        {
            //Fazendo o calculo da porcentagem
            PagamentoTotal = HorasTrabalhas * ValorPorHora;
        }
    }
}
