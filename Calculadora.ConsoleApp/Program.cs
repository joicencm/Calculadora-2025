﻿namespace Calculadora.ConsoleAPP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //vetores
            string[] historicoOperacoes = new string[100];
            int contadorHistorico = 0;

            //loop de execução - estrutura de repetição
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Calculadora Tabajara 2025");
                Console.WriteLine("-----------------------------------------");


                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Mutiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("6 - Histórico de Operações");
                Console.WriteLine("S - Sair");
                Console.WriteLine("-----------------------------------------");

                Console.Write("Escolha Opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "S")
                    break;

                else if (opcao == "5")
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("-----------------------------------------");

                    Console.Write("Digite o numero desejado: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    //1 - contador = variável de controle
                    //2 - condição
                    //3 - mecanismo de incrementação
                    for (int contador = 1; contador <= 10; contador++)
                        Console.WriteLine($"{numeroTabuada} x {contador} x {numeroTabuada * contador}");


                    Console.ReadLine();
                    continue;
                }

                else if (opcao == "6")
                { 
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Histórico de Operações");
                    Console.WriteLine("-----------------------------------------");

                    for (int contador = 0; contador < contadorHistorico; contador++)
                    {
                        Console.WriteLine(historicoOperacoes[contador]);
                    }

                    Console.ReadLine();
                    continue;
                }

                    Console.WriteLine("-----------------------------------------");
                Console.Write("Digite o primeiro numero: ");
                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Digite o segundo numero: ");
                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;
                // estrutura de decisão "Se"
                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                }

                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";

                }

                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";

                }

                else if (opcao == "4")
                {
                    while (segundoNumero == 0.0m)
                    {
                        Console.Write(" > Não pode ser 0. Digite novamente: ");

                        segundoNumero = Convert.ToDecimal(Console.ReadLine());
                    }

                    resultado = primeiroNumero / segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";


                }

                else
                {
                    Console.Write("Escolha Opção da Lista de 1 a 4 : ");
                    continue;
                }

                contadorHistorico++;

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                Console.WriteLine("-----------------------------------------");

                Console.ReadLine();
            }


        }
    }

}
