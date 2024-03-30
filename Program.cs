using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Operadores Opcoes = new Operadores();
            {
                Opcoes.Total = 5;
            }
            Calculos Calcular = new Calculos();
            {
                
            }
            Console.WriteLine($"{Opcoes.Soma} PARA SOMAR \n{Opcoes.Sub} PARA SUBTRAIR\n{Opcoes.Mult} PARA MULTIPLICAR" +
                $"\n{Opcoes.Divi} PARA DIVIDIR\n{Opcoes.Fechar} FECHAR");
             Opcoes.Total = int.Parse(Console.ReadLine());
            while (Opcoes.Total <= 5)
            {
                if (Opcoes.Total == Opcoes.Soma)
                {
                    Console.Write("DIGITE UM NUMERO: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("DIGITE OUTRO NUMERO: ");
                    int b = int.Parse(Console.ReadLine());

                    int resultado = a + b;
                    Console.WriteLine($"\nRESULTADO: {resultado}\n");

                    Console.WriteLine($"{Opcoes.Soma} PARA SOMAR \n{Opcoes.Sub} PARA SUBTRAIR\n{Opcoes.Mult} PARA MULTIPLICAR" +
                        $"\n{Opcoes.Divi} PARA DIVIDIR\n{Opcoes.Fechar} FECHAR");
                    Opcoes.Total = int.Parse(Console.ReadLine());


                }
                else if(Opcoes.Total == Opcoes.Sub)
                {
                    Console.Write("DIGITE UM NUMERO: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("DIGITE OUTRO NUMERO: ");
                    int b = int.Parse(Console.ReadLine());

                    int resultado = a - b;
                    Console.WriteLine($"\nRESULTADO: {resultado}\n");

                    Console.WriteLine($"{Opcoes.Soma} PARA SOMAR \n{Opcoes.Sub} PARA SUBTRAIR\n{Opcoes.Mult} PARA MULTIPLICAR" +
                        $"\n{Opcoes.Divi} PARA DIVIDIR\n{Opcoes.Fechar} FECHAR");
                    Opcoes.Total = int.Parse(Console.ReadLine());

                }
                else if(Opcoes.Total == Opcoes.Mult)
                {

                    Console.Write("DIGITE UM NUMERO: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("DIGITE OUTRO NUMERO: ");
                    int b = int.Parse(Console.ReadLine());

                    int resultado = a * b;
                    Console.WriteLine($"\nRESULTADO: {resultado}\n");

                    Console.WriteLine($"{Opcoes.Soma} PARA SOMAR \n{Opcoes.Sub} PARA SUBTRAIR\n{Opcoes.Mult} PARA MULTIPLICAR" +
                        $"\n{Opcoes.Divi} PARA DIVIDIR\n{Opcoes.Fechar} FECHAR");
                    Opcoes.Total = int.Parse(Console.ReadLine());


                }else if(Opcoes.Total == Opcoes.Divi)
                {

                    Console.Write("DIGITE UM NUMERO: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("DIGITE OUTRO NUMERO: ");
                    int b = int.Parse(Console.ReadLine());

                    int resultado = a / b;
                    Console.WriteLine($"\nRESULTADO: {resultado}\n");

                    Console.WriteLine($"{Opcoes.Soma} PARA SOMAR \n{Opcoes.Sub} PARA SUBTRAIR\n{Opcoes.Mult} PARA MULTIPLICAR" +
                        $"\n{Opcoes.Divi} PARA DIVIDIR\n{Opcoes.Fechar} FECHAR");
                    Opcoes.Total = int.Parse(Console.ReadLine());

                }
                else if(Opcoes.Total == Opcoes.Fechar)
                {
                    Console.WriteLine("VOCE FECHOU O PROGRAMA, VOLTE SEMPRE!");

                    break;
                }
                else
                {
                    Console.WriteLine("OPCAO INVALIDA - VOCE VOLTOU PARA O MENU\n");
                    Console.WriteLine($"{Opcoes.Soma} PARA SOMAR \n{Opcoes.Sub} PARA SUBTRAIR\n{Opcoes.Mult} PARA MULTIPLICAR" +
                        $"\n{Opcoes.Divi} PARA DIVIDIR\n{Opcoes.Fechar} FECHAR");
                    Opcoes.Total = int.Parse(Console.ReadLine());


                }
            }
        }
    }
}
