﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6
{
    partial class Rectangulo
    {
        private int lado1;
        public int Lado1
        {
            set
            { lado1 = value; }
            get
            { return lado1; }
        }
        private int lado2;
        public int Lado2
        {
            set
            { lado2 = value; }
            get
            { return lado2; }
        }
    }
}
