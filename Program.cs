using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double diagonal;
            double area;
            Console.WriteLine("digite o valor da diagonal.");
          diagonal=double.Parse(Console.ReadLine());

            area = Math.Pow(diagonal, 2) / 2;
            Console.WriteLine("valor da area é: " + area);
        }
    }
}
