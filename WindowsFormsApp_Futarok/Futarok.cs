﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Futarok
{
    internal class Futarok
    {
        public int fazon;
        public string fnev;
        public int ftel;
        public Futarok(int fazon, string fnev, int ftel)
        {
            this.fazon = fazon;
            this.fnev = fnev;
            this.ftel = ftel;
        }
        public override string ToString()
        {
            return $"{fazon} + {fnev} + {ftel}";
        }
    }
}
