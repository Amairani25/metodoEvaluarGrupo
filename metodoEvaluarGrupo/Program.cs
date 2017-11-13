using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodoEvaluarGrupo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("que desea realizar: 1) area del trinagulo 2) area  de un circulo");
                int p = int.Parse(Console.ReadLine());
                Calcular r = new Calcular() { };
                if (p == 1)
                    r.Area();

                if (p == 2)
                    r.Circulo();
            }
            catch (FormatException)
            {
                Console.WriteLine("has introduce otra cosa que no sea un numero DX");
            }
            try
            {

                Console.WriteLine("cual es tu edad");
                int e = int.Parse(Console.ReadLine());
                if (e >= 18)
                    Console.WriteLine("eres mayor de edad");
                else
                    Console.WriteLine("a un eres legal");
            }
            catch (FormatException)
            {
                Console.WriteLine("en numeros ");
            }
            Console.ReadKey();
        }
    }
 }
    