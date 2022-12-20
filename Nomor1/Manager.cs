using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasInheritance.Nomor1
{
    internal class Manager : CEO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthDateString => BirthDate?.ToString("dd/MM/yyyy") ?? "";
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? ManagerType { get; set; }
        public string? NamaPerusahaan { get; set; }
        public List<Staff> Staff { get; set; }



        public void introduction()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Halo perkenalkan Saya:");
            Console.WriteLine("Nama: {0}", this.Name);
            Console.WriteLine("Alamat: {0}", this.Address);
            Console.WriteLine("Nomor HP: {0}", this.Phone);
            Console.WriteLine("Posisi: {0}", this.ManagerType);
            Console.WriteLine("Tanggal Lahir: {0}", this.BirthDateString);
            Console.WriteLine("Gaji: {0}", this.Salary);
            Console.WriteLine("Nama Perusahaan: {0}", this.NamaPerusahaan);
            Console.WriteLine("Bawahan saya adalah:");

            foreach (var bawahan in this.Staff)
            {
                Console.WriteLine("Id: {0}", bawahan.Id);
                Console.WriteLine("Name: {0}", bawahan.Name);
            }
            Console.WriteLine("========================================================");

        }
    }
}

