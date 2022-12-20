using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasInheritance;

namespace TugasInheritance
{
    class Darat : Hewan
    {
        protected void Jalan()
        {
            Console.WriteLine("Berjalan di darat");
        }
        public override void Bernafas()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("Bernafas dengan insang");
        }

    }
}
