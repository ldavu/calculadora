using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("calculadora feita em C#");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Escreva um numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva outro número");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha a operação");
            Console.WriteLine("\ta - adição ");
            Console.WriteLine("\ts - subtração ");
            Console.WriteLine("\tm - multiplicação ");
            Console.WriteLine("\td - divisão ");

            operacoes(num1, num2);

            static void operacoes(int num1, int num2)
            {
                switch (Console.ReadLine())
                {
                    case "a":
                        Console.WriteLine($"O seu resultado de {num1} + {num2} = " + (num1 + num2));
                        break;

                    case "s":
                        Console.WriteLine($"O resultado de {num1} - {num2} = " + (num1 - num2));
                        break;

                    case "m":
                        Console.WriteLine($"O resultado de {num1} x {num2} = " + (num1 * num2));
                        break;

                    case "d":
                        Console.WriteLine("O resultado de {num1} / {num2} = " + (num1 % num2));
                        break;

                }   
            }
        }
    }
}
