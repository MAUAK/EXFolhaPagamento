using System;
using System.Collections.Generic;
using System.Text;

namespace Folha_de_Pagamento
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double DespezaAdicional { get; set; }
        public FuncionarioTerceirizado(double despezaadicional)
        {
            DespezaAdicional = despezaadicional;
        }

        //Reescrevendo o método para calcular a área corretamente do retângulo
        /*public override double SalarioTotal()
        {
            //Calculo da área do retângulo
            return Largura * Altura;
        }*/
    }
}
