namespace Beräkna_befruktning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Befruktningsdag();
        }

        static public void Befruktningsdag()
        {
            var martin = new DateTime(1987, 11, 26);
            Console.WriteLine($"Född       : {martin.ToString("dd MMM yyyy")}"); 
            var befruktning = martin.AddMonths(-9);
            Console.WriteLine($"Befruktades: {befruktning.ToString("dd MMM yyyy")}");
        }
    }
}