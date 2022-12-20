using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasInheritance
{
    class Paus : Air
    {
        String NamaHewan = "Paus";
        public void Berenang()
        {
            Console.WriteLine(NamaHewan + " Berenang di laut");
        }
        public void Bernafas()
        {
            Console.WriteLine(NamaHewan + " Bernafas");
        }
    }
}
