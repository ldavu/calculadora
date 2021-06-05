using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var continuar = "s";
            do
            {
                Console.Clear();
                int num1 = 0;
                int num2 = 0;

                Console.WriteLine("Calculadora em C#");
                Console.WriteLine("-----------------");

                Console.WriteLine("Escreva um numero");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escreva outro numero");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escolha a operação que deseja fazer");
                Console.WriteLine("\ta - Adição");
                Console.WriteLine("\ts - Subtração");
                Console.WriteLine("\tm - Multiplicação");
                Console.WriteLine("\td - divisão");

                
                operacoes(num1, num2);

                
                Console.WriteLine("Deseja continuar? s//n");
                continuar = Console.ReadLine();

            } while (continuar == "s");
            static void operacoes(int num1, int num2)
            {
                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"A soma de {num1} + {num2} = " + (num1 + num2));
                        break;
                    case "s":
                        Console.WriteLine($"A subtração de {num1} - {num2} = " + (num1 - num2));
                        break;
                    case "m":
                        Console.WriteLine($"A multiplicação de {num1} x {num2} = " + (num1 * num2));
                        break;
                    case "d":
                        Console.WriteLine($"A divisão de {num1} / {num2} = " + (num1 / num2));
                        break;
                }
            }
        }
    }
}
