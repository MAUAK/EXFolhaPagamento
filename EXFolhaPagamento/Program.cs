using System;
using System.Collections.Generic;

namespace Folha_de_Pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ----------------- KAUAM SILVA BATISTA - 210501 ----------- 
             */

            //Colocando o número de funcionários
            Console.WriteLine("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            //Criando lista de funcionários
            List<Funcionario> funcionarios = new List<Funcionario>();

            //Criando uma estrututra de repetição para colocar os valores em cada funcionarios
            for (int i = 0; i < n; i++)
            {
                //Pedindo e colocando o nome
                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();

                //Pedindo e colocando o salário
                Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
                double horastrabalhadas = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
                double valorporhora = double.Parse(Console.ReadLine());

                //Colocando todos os valores de todas as variaveis em um funcionario
                funcionarios.Add(new Funcionario { Nome = nome, HorasTrabalhas = horastrabalhadas, ValorPorHora = valorporhora });
            }

            Funcionario func = new Funcionario();

            func.Salario();

            //Pulando linha
            Console.WriteLine();
            //Imprimindo autalização
            Console.WriteLine("\nLista atualizada dos funcionários: ");
            int t = 0;
            //Para cada item da lista imprimindo seus valores
            foreach (var item in funcionarios)
            {
                t++;
                Console.WriteLine("\nFuncionário #" + t + ": ");
                Console.WriteLine(item.Nome + ", " + item.PagamentoTotal);
                // Console.WriteLine(item.Nome);
                //Console.WriteLine("Salario: " + item.Salario);
                Console.WriteLine("--------------");
            }
        }
    }
}