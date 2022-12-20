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


            // Main Nomor 1
            //tes presiden
            var presiden1 = new CEO
            {
                Id = Guid.NewGuid(),
                Name = "Budi",
                BirthDate = new DateTime(1994, 2, 5),
                Address = "Jakarta",
                Phone = "084756728947",
                Salary = 10000000,
                NamaPerusahaan = "Bakso Keliling",
                Manager = new List<Manager>
                {
                new Manager { Id = Guid.NewGuid(), Name = "Joni"}
                }
            };
            var presiden2 = new CEO
            {
                Id = Guid.NewGuid(),
                Name = "King",
                BirthDate = new DateTime(1994, 2, 5),
                Address = "Jakarta",
                Phone = "084756728947",
                Salary = 1000000000,
                NamaPerusahaan = "Kingdom",
                Manager = new List<Manager>
                {
                new Manager {  Id = Guid.NewGuid(), Name = "Brook"},
                new Manager {  Id = Guid.NewGuid(), Name = "Knight"}
                }
            };
            var presiden3 = new CEO
            {
                Id = Guid.NewGuid(),
                Name = "John Wick",
                BirthDate = new DateTime(1999, 2, 4),
                Address = "Jakarta",
                Phone = "084756728947",
                Salary = 100000000,
                NamaPerusahaan = "PT.Mencari Cinta Sejati",
                Manager = new List<Manager>
                {
                new Manager {  Id = Guid.NewGuid(), Name = "John Doe"},
                new Manager {  Id = Guid.NewGuid(), Name = "John Pantau"},
                new Manager {  Id = Guid.NewGuid(), Name = "John WikWIk"}
                }
            };
            presiden1.introduction();
            presiden2.introduction();
            presiden3.introduction();

            //tes manager

            var manager1 = new Manager
            {
                Id = Guid.NewGuid(),
                Name = "Alpha",
                BirthDate = new DateTime(1999, 2, 4),
                Address = "Jakarta",
                Phone = "084756728947",
                Salary = 1000000,
                ManagerType = "Manager IT",
                NamaPerusahaan = "PT CUAN",
                Staff = new List<Staff>
                {
                new Staff { Id = Guid.NewGuid(), Name = "Beta"},
                new Staff { Id = Guid.NewGuid(), Name = "Charlie"},
                new Staff { Id = Guid.NewGuid(), Name = "Delta"}
                }
            };

            manager1.introduction();

            //tes programmer 

            var staff1 = new Staff
            {
                Id = Guid.NewGuid(),
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