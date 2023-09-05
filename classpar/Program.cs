using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }using System;

class ParImpar
    {
        static void Main()
        {
            int numero;

            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par");
            }
            else
            {
                Console.WriteLine("El número es impar");
            }
        }
    }
}
}
