using System;
using System.Collections.Generic;
using System.Text;

namespace Folha_de_Pagamento
{
    class Funcionario
    {
        //Criando a variavel nome com encapsulamento
        public string Nome { get; set; }
        //Criando a variavel de horas trabalhadas com encapsulamento
        public double HorasTrabalhas { get; set; }
        //Criando a variavel de valor por hora com encapsulamento
        public double ValorPorHora { get; set; }
        //Criando a variavel de pagamento total com encapsulamento
        public double PagamentoTotal { get; set; }

        //Criando um construtor da classe funcionário e passando os paramêtros
        public Funcionario(string nome, double horastrabalhadas, double valorporhora, double pagamentototal)
        {
            //Igualando os paramêtros com as váriaveis
            Nome = nome;
            HorasTrabalhas = horastrabalhadas;
            ValorPorHora = valorporhora;
            PagamentoTotal = pagamentototal;
        }

        //Criando o método para imprimir as informações
        public virtual string Salarios()
        {
            //Retornando as informações de nome e pagamento total
            return Nome + " - Pagamento totaL R$" + PagamentoTotal;
        }
    }
}
