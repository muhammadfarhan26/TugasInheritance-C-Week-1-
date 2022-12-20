using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasInheritance
{
    class Air : Hewan
    {
        protected void Berenang()
        {

            Console.WriteLine("Berenang di Air");
        }

        public override void Bernafas()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("Bernafas dengan insang");
        }
    }
}
