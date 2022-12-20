using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TugasInheritance.Nomor1
{
    internal class CEO
    {
        /*Id - int
Name - string
BirthDate - string format dd-M-yyyy
Address - string
Phone - string
Position - string
Lists (1 atau lebih seusaikan dengan kebutuhan)*/

        int? id;
        string? name;
        string? birthdate;
        string? address;
        string? phone;
        string? position;

        public CEO()
        {
            position = "CEO"; // Set the initial value for model
        }


    }
}
