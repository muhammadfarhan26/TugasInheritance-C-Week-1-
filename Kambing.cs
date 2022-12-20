using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasInheritance
{
    class Kambing : Darat
    {
        String NamaHewan = "Kambing";
        public void Jalan()
        {
            Console.WriteLine(NamaHewan + " Berjalan di darat");
        }
        public void Bernafas()
        {
            Console.WriteLine(NamaHewan + " Bernafas");
        }
    }
}
