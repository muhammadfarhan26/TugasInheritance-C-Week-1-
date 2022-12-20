namespace TugasInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sapi cow = new Sapi();

            cow.Jalan();
            cow.Bernafas();

            Hiu shark = new Hiu();

            shark.Berenang();
            shark.Bernafas();

            Elang eagle = new Elang();

            eagle.Terbang();
            eagle.Bernafas();

        }
    }
}