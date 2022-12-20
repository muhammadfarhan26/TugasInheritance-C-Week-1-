using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasInheritance
{
    class Elang : Udara
    {
        String NamaHewan = "Elang";
        public void Terbang()
        {
            Console.WriteLine(NamaHewan + " Terbang di Udara");
        }
        public void Bernafas()
        {
            Console.WriteLine(NamaHewan + " Bernafas");
        }
    }
}
