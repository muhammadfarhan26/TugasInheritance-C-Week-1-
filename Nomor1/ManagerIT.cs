using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasInheritance.Nomor1
{
    internal class ManagerIT : CEO
    {
        int? id;
        string? name;
        string? birthdate;
        string? address;
        string? phone;
        string? position;

        public ManagerIT() 
        {
            position = "Manager IT"; // Set the initial value for model
        }
    }
}
