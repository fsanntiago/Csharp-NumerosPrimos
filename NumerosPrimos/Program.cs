using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("VERIFICADOR DE NÚMEROS PRIMOS");
            Console.WriteLine("-----------------------------");
            try
            {
                while (true)
                {
                    Console.Write("Digite um número: ");
                    string number = Console.ReadLine();
                    bool result = IsPrimeNumber(number);

                    if (result)
                    {
                        Console.WriteLine(number + " é primo.");
                    }
                    else
                    {
                        Console.WriteLine(number + " não é primo.");
                    }
                    Console.WriteLine("[ENTER] - Outro nuúmero");
                    Console.WriteLine("[ESC] - Sair\n");
                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ToString());

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

            }
            Console.ReadLine();
        }

        public static bool IsPrimeNumber(string number)
        {
            try
            {
                int checkedNumber = CheckNumber(number);
                int div = 0;
                for (int aux = 2; aux <= checkedNumber / 2; aux++)
                {
                    if (checkedNumber % aux == 0)
                    {
                        div++;
                    }
                }
                return div == 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int CheckNumber(string number)
        {
            bool sucess = Int32.TryParse(number, out int result);
            if (sucess)
            {
                if (result < 0)
                {
                    throw new ArgumentException("Entrada invalida: número negativo.");
                }
                return result;
            }
            throw new ArgumentException("Entrada invalida: Contém letra(s)");
        }
    }
}
