using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasInheritance
{
    class Udara : Hewan
    {
        protected void Terbang()
        {
            Console.WriteLine("Terbang di Udara");
        }
        public override void Bernafas()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("Bernafas dengan pundi-pundi udara");
        }
    }
}
