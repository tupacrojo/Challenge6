using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6
{
    partial class Vehiculo
    {
        bool brake= false;
        string pregunta = "n";
        public bool Frenar() 
        {   bool freno;
            pregunta = "s";
                brake = true;
                velocidad = 0;
                Console.WriteLine("ihhhgggmm");
                freno = brake;
            return freno;

        }
        public int Acelerar() 
        {
            int acelerador = 100;
            velocidad = acelerador; 
            return acelerador;

        }
        public bool Arrancar()
        {
            bool arranque = false;
            string llave;
            Console.WriteLine("tenes la llave \n s/n");
            llave = Console.ReadLine();
            if (llave == "s")
            {
                arranque = true;
                estadoMotor = true;
                Console.WriteLine("brum...");
                string pregunta;
                Console.WriteLine("arrancamos? \n s/n");
                pregunta = Console.ReadLine();
                if (pregunta == "s")
                {
                    Acelerar();
                    pregunta = "n";
                if (velocidad > 0)
                {
                    Console.WriteLine("fiuuuum");
                }
                    Console.WriteLine("queres frenar? \n s/n");
                    pregunta = Console.ReadLine();
                    if (pregunta == "s")
                    {
                        Frenar();
                        //pregunta = "n";
                    }
                }
                return arranque;

            }
            else
            {
                arranque = false;
                estadoMotor = false;
                Console.WriteLine("anda a buscar la llave");
                return arranque;
            }
        }
    }
}
