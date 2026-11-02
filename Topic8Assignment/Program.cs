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
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Enter a number.");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
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
            for (int ii = 0; ii < randNumbers.Count; ii++)
            {
                if (randNumbers[ii] == 10)
                {
                    Console.Write("ten, ");
                }
                else if (randNumbers[ii] == 20)
                {
                    Console.Write("twenty, ");
                }
                else if (randNumbers[ii] == 30)
                {
                    Console.Write("thirty, ");
                }
                else if (randNumbers[ii] == 40)
                {
                    Console.Write("fourty, ");
                }
                else
                {
                    Console.Write(randNumbers[ii] + ", ");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            for (int ii = 0; ii < randNumbers.Count; ii++)
            {
                randNumbers[ii] = randNumbers[ii] * 2;
                Console.Write(randNumbers[ii] + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            for (int ii = 0; ii < randNumbers.Count; ii++)
            {
                if (randNumbers[ii] < 50)
                {
                    Console.Write("0, ");
                }
                else
                {
                    Console.Write(randNumbers[ii] + ", ");
                }

            }
            Console.WriteLine("");
            Console.WriteLine("");
            for (int ii = 0; ii < randNumbers.Count; ii++)
            {
                Console.Write(randNumbers[ii] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            List<string> colors = new List<string>();
            for (int iii = 0; iii < 5; iii++)
            {

                Console.WriteLine("Enter the name of a color.");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                colors.Add(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            for (int iii = 0; iii < colors.Count; iii++)
            {
                Console.Write(colors[iii] + ", ");
            }
            Console.WriteLine("");
            int randomColor = 0;
            randomColor = (generator.Next(1, 5));
            if (randomColor == 1)
            {
                Console.WriteLine(colors[1] + " Wins.");
            }
            else if (randomColor == 2)
            {
                Console.WriteLine(colors[2] + " Wins.");
            }
            else if (randomColor == 3)
            {
                Console.WriteLine(colors[3] + " Wins.");
            }
            else if (randomColor == 4)
            {
                Console.WriteLine(colors[4] + " Wins.");
            }
            else if (randomColor == 5)
            {
                Console.WriteLine(colors[5] + " Wins.");
            }
            List<int> randyList = new List<int>();
            int reqAmount = 0, minValue = 0, maxValue = 0;
            Console.WriteLine("How many numbers do you need?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out reqAmount);
            randyList.Capacity = reqAmount;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Max value?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out maxValue);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Min value?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out minValue);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int iiii = 0; iiii < randyList.Capacity; iiii++)
            {
                randyList.Add(generator.Next(minValue, maxValue));
            }
            Console.WriteLine("List on one line:");
            for (int iiii = 0; iiii < randyList.Capacity; iiii++)
            {
                Console.Write(randyList[iiii] + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("Name a number.");
            int choice, choiceAppear = 0;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out choice);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int iiii = 0; iiii < randyList.Capacity; iiii++)
            {

                if (randyList[iiii] == choice)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(randyList[iiii] + ", ");
                    choiceAppear++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(randyList[iiii] + ", ");
                }


            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("");
            Console.WriteLine("");
            if (choiceAppear == 0)
            {
                Console.WriteLine("It doesn't appear.");
            }
            else
            {
                Console.WriteLine("Appearences of that number: " + choiceAppear);
            }

        }
    }
}
