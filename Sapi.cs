﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasInheritance
{
    class Sapi : Darat
    {
        string NamaHewan = "Sapi";
        public void Jalan()
        {
            Console.WriteLine(NamaHewan+ " Berjalan di darat");
        }
        public void Bernafas()
        {
            Console.WriteLine(NamaHewan + " Bernafas");
        }
    }
}
