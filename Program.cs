using TugasInheritance.Nomor1;

namespace TugasInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //No2
            /*Sapi cow = new Sapi();

            cow.Jalan();
            cow.Bernafas();

            Hiu shark = new Hiu();

            shark.Berenang();
            shark.Bernafas();

            Elang eagle = new Elang();

            eagle.Terbang();
            eagle.Bernafas();
            */
            var presiden1 = new CEO
            {
                Id = 1,
                Name = "Budi",
                BirthDate = new DateTime(1994, 2, 5),
                Address = "Jakarta",
                Phone = "084756728947",
                Salary = 10000000,
                NamaPerusahaan = "Bakso Keliling",
                Manager = new List<Manager>
                {
                new Manager { Id = 2, Name = "Joni"}
                }
            };
            var presiden2 = new CEO
            {
                Id = 1,
                Name = "King",
                BirthDate = new DateTime(1994, 2, 5),
                Address = "Jakarta",
                Phone = "084756728947",
                Salary = 1000000000,
                NamaPerusahaan = "Kingdom",
                Manager = new List<Manager>
                {
                new Manager { Id = 2, Name = "Brook"},
                new Manager { Id = 3, Name = "Knight"}
                }
            };
            var presiden3 = new CEO
            {
                Id = 1,
                Name = "John Wick",
                BirthDate = new DateTime(1999, 2, 4),
                Address = "Jakarta",
                Phone = "084756728947",
                Salary = 100000000,
                NamaPerusahaan = "PT.Mencari Cinta Sejati",
                Manager = new List<Manager>
                {
                new Manager { Id = 2, Name = "John Doe"},
                new Manager { Id = 3, Name = "John Pantau"},
                new Manager { Id = 4, Name = "John WikWIk"}
                }
            };
            presiden1.introduction();
            presiden2.introduction();
            presiden3.introduction();

            //tes manager

            var manager1 = new Manager
            {
                Id = 1,
                Name = "Alpha",
                BirthDate = new DateTime(1999, 2, 4),
                Address = "Jakarta",
                Phone = "084756728947",
                Salary = 1000000,
                ManagerType = "Manager IT",
                NamaPerusahaan = "PT CUAN",
                Staff = new List<Staff>
                {
                new Staff { Id = 2, Name = "Beta"},
                new Staff { Id = 3, Name = "Charlie"},
                new Staff { Id = 4, Name = "Delta"}
                }
            };

            manager1.introduction();

            //tes programmer 

            var staff1 = new Staff
            {
                Id = 1,
                Name = "A",
                BirthDate = new DateTime(1999, 2, 4),
                Address = "Jakarta",
                Phone = "084756728947",
                Salary = 1000000,
                Division = "Programmer",
                NamaPerusahaan = "PT CUAN"
            };
            staff1.introduction();
        }
    }
}