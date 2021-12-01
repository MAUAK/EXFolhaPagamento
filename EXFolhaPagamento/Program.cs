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

            //Colocando o número de funcionários e lendo em uma refência
            Console.WriteLine("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            //Criando lista de funcionários
            List<Funcionario> funcionarios = new List<Funcionario>();

            //Criando uma estrututra de repetição para colocar os valores em cada funcionarios
            for (int i = 0; i < n; i++)
            {
                //Pedindo e colocando o nome
                Console.WriteLine("\nDigite o nome do: " + (i+1) + "º funcionário. ");
                string nome = Console.ReadLine();

                //Pedindo e colocando o salário
                Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
                double horastrabalhadas = double.Parse(Console.ReadLine());

                //Pedindo e colocando a quantidade de horas trabalhadas
                Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
                double valorporhora = double.Parse(Console.ReadLine());

                //Perguntando se o funcionário é normal ou terceirizado
                Console.Write("Normal ou terceirizado (N/T)? ");
                //Guardando na variável
                char ch = char.Parse(Console.ReadLine());

                //Fazendo o calculo de pagamento total
                double pagamentotal = horastrabalhadas * valorporhora;

                //Verificando se o funcionário é normal
                if (ch == 'N')
                {          
                    //Adicionando os dados do funcionário normal na lista de funcionário
                    funcionarios.Add(new Funcionario(nome, horastrabalhadas, valorporhora, pagamentotal));
                }
                //Verificando se o funcionário é terceirizado
                else if (ch == 'T')
                {
                    //Fazendo o cauculo do pagamento do funcionário terceirizado
                    pagamentotal =+ pagamentotal * 1.1;
                    //Guardando o valor do pagamento atual em despezasadicionais
                    double despesaadicional = pagamentotal;
                    //Adicionando os dados do funcionário terceirizado na lista de funcionário
                    funcionarios.Add(new FuncionarioTerceirizado(nome, horastrabalhadas, valorporhora, pagamentotal, despesaadicional));
                }                
            }           

            //Pulando linha
            Console.WriteLine();
            //Imprimindo autalização
            Console.WriteLine("\nLista atualizada dos funcionários: ");
            //Criando um contador
            int t = 0;
            //Para cada item da lista imprimindo seus valores
            foreach (var item in funcionarios)
            {
                //Somando no contador para ver a posição do funcionário atual
                t++;
                //Imprimindo a posição do funcionário
                Console.WriteLine("\nFuncionário #" + t + ": ");
                //Chamando o métodos salarios
                Console.WriteLine(item.Salarios());
                Console.WriteLine("--------------");
            }
        }
    }
}