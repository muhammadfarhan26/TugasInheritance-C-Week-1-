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

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthDateString => BirthDate?.ToString("dd/MM/yyyy") ?? "";
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Position { get; set; }

        public double? Salary { get; set; }

        public string? NamaPerusahaan { get; set; }

    public List<Manager> Manager { get; set; }


        public CEO()
        {
            Position = "CEO"; // Set the initial value for model
        }

        public void introduction()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Halo perkenalkan Saya:");
            Console.WriteLine("Nama: {0}", this.Name);
            Console.WriteLine("Alamat: {0}", this.Address);
            Console.WriteLine("Nomor HP: {0}", this.Phone);
            Console.WriteLine("Posisi: {0}", this.Position);
            Console.WriteLine("Tanggal Lahir: {0}", this.BirthDateString);
            Console.WriteLine("Gaji: {0}", this.Salary);
            Console.WriteLine("Nama Perusahaan: {0}", this.NamaPerusahaan);
            Console.WriteLine("Bawahan saya adalah:");
  
            foreach (var bawahan in this.Manager)
            {
                Console.WriteLine("Id: {0}", bawahan.Id);
                Console.WriteLine("Name: {0}", bawahan.Name);
            }
            Console.WriteLine("========================================================");
        }


    }
}
