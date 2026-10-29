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
            Console.WriteLine(names[3] + " ate Archangel Michael");
            Console.WriteLine(names[0]);
            names[4] = "Schlypher";
            Console.WriteLine(names[4]);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(i + ". " + names[i]);
            }


            List<int> numbers = new List<int>();
            for (int ii = 0; ii < 10; ii++)
            {
                Console.WriteLine("Enter a number.");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("The fattest number is: " + numbers.Max());
            Console.WriteLine("The puniest number is: " + numbers.Min());
            Console.WriteLine("The sum probably is: " + numbers.Sum());
            Console.WriteLine("The average probably is: " + numbers.Average());

            for (int ii = 0; ii < numbers.Count; ii++)
            {
                Console.Write(numbers[ii] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Random generator = new Random();
            List<int> randNumbers = new List<int>();
            for (int ii = 0; ii < 40; ii++)
            {

                randNumbers.Add(generator.Next(1, 40));

            }
            for (int ii = 0; ii < randNumbers.Count; ii++)
            {
                Console.Write(randNumbers[ii] + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("The fattest number is: " + randNumbers.Max());
            Console.WriteLine("The puniest number is: " + randNumbers.Min());
            Console.WriteLine("The average probably is: " + randNumbers.Average());

        }
    }
}
