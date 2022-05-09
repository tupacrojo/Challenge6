using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6
{
    partial class Vehiculo
    {
        private bool estadoMotor = false;
        private int velocidad;
        
        public bool EstadoMotor
        {
            set
            { estadoMotor = value; }
            get
            { return estadoMotor; }
        }
        public int Velocidad
        {
            set
            { velocidad = value; }
            get
            { return velocidad; }
        }
    }
}
