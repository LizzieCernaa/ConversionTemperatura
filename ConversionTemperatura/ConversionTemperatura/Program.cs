using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola PROYECTO");
            Console.WriteLine("Lizzie Cerna");
            Console.WriteLine("Fredy Cerna");
            Console.WriteLine("Hola buen día Lizzie");

            Console.WriteLine("Ingresa un nuvero");
            int num = int.Parse(Console.ReadLine());

            double multi = 1.8;
            int grado = 32;
            int resultado = (int)(num * multi + grado);   
           
            int multiplicacion = (int)(num * multi);

            Console.WriteLine("Los grados Fahrenheit son =" + resultado);

            Console.ReadKey();
        }
    }
}
