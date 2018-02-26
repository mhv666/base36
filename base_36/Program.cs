using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace base_36
{
    class Program
    {
        private static string ToBase36(ulong numero)
        {
            const string base36 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var sb = new StringBuilder(13);
            do
            {
                sb.Insert(0, base36[(byte)(numero % 36)]);
                numero /= 36;
            } while (numero != 0);
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            if (int.Parse(args[0]) < 0)
            {
                Console.WriteLine("numero "+ args[0] + " El numero no puede ser negativo");             
            }
            else
            {
                ulong numero = ulong.Parse(args[0]);

                string result = ToBase36(numero);


                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("|******************************************************************************|");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                              el numero convertido es: " + result);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("|******************************************************************************|");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ReadKey();
            }
        }
    }
}
