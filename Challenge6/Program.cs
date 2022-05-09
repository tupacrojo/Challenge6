using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selector = 0;
            Console.WriteLine("\n Ej1 = 1 \n Ej2 = 2");
            selector = Int32.Parse(Console.ReadLine());
            switch (selector)
            {
                case 1:
                    Rectangulo rectangulo1 = new Rectangulo();
                    rectangulo1.Lado1 = 3;
                    rectangulo1.Lado2 = 7;
                    Console.WriteLine("La superficie del rectángulo es:" +
                                        rectangulo1.RetornarSuperficie());
                    Console.WriteLine("El perímetro del rectángulo es:" +
                                        rectangulo1.RetornarPerimetro());
                    Console.ReadKey();
                 break;

                case 2:
                    Console.WriteLine("ej2");
                    Vehiculo auto = new Vehiculo();
                    auto.Arrancar();
                 break;
            }
            
        }
    }
}
