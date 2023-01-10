using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("informe seu peso em kg: ");
            double peso = Double.Parse(Console.ReadLine());

            Console.Write("Informe seu altura: ");
            double altura = double.Parse(Console.ReadLine());




            double valorIMC = peso / (altura * altura);
            Console.WriteLine(valorIMC);

            if (valorIMC < 18.5)
                Console.WriteLine("\nIMC = "+ valorIMC + " baixo do peso333333");

            if ((valorIMC >= 18.5) && (valorIMC <= 24.9))
                Console.WriteLine("\nIMC = " + valorIMC + " peso normal");

            if ((valorIMC >= 25) && (valorIMC <= 29.9))
                Console.WriteLine("\nIMC = " + valorIMC + " sobrepeso");

            if ((valorIMC >= 30) && (valorIMC <= 34.9))
                Console.WriteLine("\nIMC = " + valorIMC + " acima do peso (Obesidade I) ");

            if ((valorIMC >= 35) && (valorIMC <=39.9))
                Console.WriteLine("\nIMC = " + valorIMC + " acima do peso  (Obesidade II) ");

            if (valorIMC >= 40) 
               Console.WriteLine("\nIMC = " + valorIMC + " acima do peso  (Obesidade III) ");


        }
    }
}
