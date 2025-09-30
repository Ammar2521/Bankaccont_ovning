namespace uppgift__4___träningskastet
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Random kastet = new Random();
           
            // metoden av första träningen och andra täningen.
            int förstatäingen = kastet.Next(1, 7);
            Console.WriteLine("kasta förtsa täningen: "); 
            Console.ReadKey();
            Console.WriteLine($"Du kastade: {förstatäingen}");

            int andratäningen = kastet.Next(1, 7);
            Console.WriteLine("kasta andra täningen: ");
            Console.ReadKey();
            Console.WriteLine($"Du kastade: {andratäningen}");

            Console.WriteLine($"Resultatet: {förstatäingen + andratäningen}");




        }
    }
}
