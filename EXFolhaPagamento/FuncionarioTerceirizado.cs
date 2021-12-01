using System;
using System.Collections.Generic;
using System.Text;

namespace Folha_de_Pagamento
{
    //Criando uma subclasse da classe funcionario
    class FuncionarioTerceirizado : Funcionario
    {
        //Criando a variavel de pagamento total com encapsulamento
        public double DespezaAdicional { get; set; }

        //Criando um construtor da classe do funcionário terceirizado e passandi como basse os paramêtros de nome, horas trabalhadas e valor por hora (da classe funcionário)
        public FuncionarioTerceirizado(string nome, double horastrabalhadas, double valorporhora, double despezaadicional, double pagamentototal) : base (nome, horastrabalhadas, valorporhora, pagamentototal)
        {
            //Igualando os paramêtros com as váriaveis
            Nome = nome;
            HorasTrabalhas = horastrabalhadas;
            ValorPorHora = valorporhora;
            DespezaAdicional = despezaadicional;
            PagamentoTotal = pagamentototal;
        }

        //Reescrevendo o método para imprimir o pagamento com as despezas
        public override string Salarios()
        {
            //Retornando as informações de nome e pagamento atualizado
            return Nome + " - Pagamento totaL R$" + DespezaAdicional;
        }
    }
}
