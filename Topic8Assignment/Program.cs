namespace Topic8Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Chungy", "Zargothrax", "John Smith", "Gorlock The Destroyer", "The Big Cheese" };
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(names[1] + " has a visceral hated for Dundee, Scotland");
            Console.WriteLine(names[3] + " enjoys white bread and long walks on the beach");
            Console.WriteLine("There are " + names.Count + " of these freaks");
            names[3] = "Jose Gargleface";
            Console.WriteLine(names[3] + " ate Archangel Azrael");
            Console.WriteLine(names[0]);
            names[4] = "Schlypher";
            Console.WriteLine(names[4]);
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + ". " + names[i]);
            }

        }
    }
}
