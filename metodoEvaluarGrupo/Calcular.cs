using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodoEvaluarGrupo
{
    class Calcular
    {
        public int a { get; set; }
        public int b { get; set; }
        public double c { get; set; }
        public double pi = 3.1416;

        public void Area()
        {
            Console.WriteLine("introduce la altura del rectangulo:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("introduce la base del rectangulo:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("la area del rectangulo es:" + a * b);
        }

        public void Circulo()
        {

            Console.WriteLine("introduce el area del circulo:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("el area  del circulo es:" + pi * (c * c));

        }
    }
}
