using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasInheritance.Nomor1
{
    internal class Staff : Manager
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthDateString => BirthDate?.ToString("dd/MM/yyyy") ?? "";
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Division { get; set; }
        public string? NamaPerusahaan { get; set; }

        public void introduction()
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("Halo perkenalkan Saya:");
            Console.WriteLine("Nama: {0}", this.Name);
            Console.WriteLine("Alamat: {0}", this.Address);
            Console.WriteLine("Nomor HP: {0}", this.Phone);
            Console.WriteLine("Posisi: {0}", this.Division);
            Console.WriteLine("Tanggal Lahir: {0}", this.BirthDateString);
            Console.WriteLine("Gaji: {0}", this.Salary);
            Console.WriteLine("Nama Perusahaan: {0}", this.NamaPerusahaan);
            Console.WriteLine("========================================================");
        }

    }
}
