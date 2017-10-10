using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> testScores = new List<int>() { 98, 100, 76, 84, 93 }; //an array you can't add. But a list...
            testScores.Add(80);
            testScores.Add(99);

            testScores.Remove(100);

            //start from empty list
            List<int> luckyNumbers = new List<int>();
            luckyNumbers.Add(2);
            luckyNumbers.Add(3);
            luckyNumbers.Add(7);
            luckyNumbers.Add(5);
            luckyNumbers.Add(1);
            //Console.WriteLine(luckyNumbers.Count);
                       
            //Console.WriteLine(luckyNumbers[luckyNumbers.Count-1]);

            List<string> favefoods = new List<string>() { "steak", "pasta", "chicken", "soup", "vodka" };
            //List check. Writes individgez
            //Console.WriteLine(favefoods[0]);
            //Console.WriteLine(favefoods[1]);
            //Console.WriteLine(favefoods[4]);

            List<string> leastFavFoods = new List<string>();
            leastFavFoods.Add("Shrimp");
            leastFavFoods.Add("Liver");
            leastFavFoods.Add("Small Fish");

            //change!
            leastFavFoods[0] = "Chinese Take-Out";
            //Console.WriteLine(leastFavFoods[0]);

            List<string> faveFilms = new List<string>() { "Spirited Away", "My Neighbor Totoro", "Robin Hood: Men in Tights", "Monty Python and the Holy Grail" };
            //let's loop through the list
            //for (int i = 0; i < faveFilms.Count; i++)
            //{
            //    Console.WriteLine(faveFilms[i]);
            //}

            faveFilms.Insert(0, "Dr. Horrible's Sing Along Blog");
            faveFilms.Insert(1, "Atlantis");
            faveFilms.Insert(2, "Inside Out");
            faveFilms.Insert(4, "Moana");

            Console.WriteLine();

            //foreach (string film in faveFilms)
            //{
            //    Console.WriteLine(film);
            //}

            faveFilms.Remove("Atlantis"); //case sensitive
            faveFilms.Remove("Robin Hood: Men in Tights");
            //Console.WriteLine();

            //foreach (string film in faveFilms)
            //{
            //    Console.WriteLine(film);
            //}

            //DO IT

            List<string> aminals = new List<string>();
            aminals.Add("Experiment 626");
            aminals.Add("Giraffe");
            aminals.Add("Elephant");
            aminals.Add("Orca");
            aminals.Add("Rhino");

            foreach (string aminal in aminals)
            {
                Console.WriteLine(aminal);
            }

            Console.WriteLine();

            List<bool> boolList = new List<bool>() { true, false, false, true, false };
            
            foreach (bool bol in boolList)
            {
                if( bol) //because bol = true 
                {
                    Console.WriteLine("Better bring an umbrella");
                }
                else
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }
            }

            Console.WriteLine();

            List<int> numbers = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));

            numbers.Remove(27);
            numbers.Remove(77);
            numbers.Remove(32);
            numbers.Remove(6);

            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));

            Console.WriteLine();

            List<int> birthdayDays = new List<int>() { 2, 21, 21, 14, 9, 20 };
            
            Console.WriteLine(birthdayDays.IndexOf(21));
            birthdayDays.Sort();
            Console.WriteLine(birthdayDays.IndexOf(21));

            Console.WriteLine();

            for (int i = 0; i < birthdayDays.Count; i++)
            {
                Console.WriteLine("On day number " + birthdayDays[i] + " of your month, happy birthday!");
            }

            birthdayDays.Clear();
            
            foreach (int day in birthdayDays)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();

            birthdayDays.Add(1);
            birthdayDays.Add(30);

            foreach (int day in birthdayDays)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();

            Console.WriteLine("What's your birthday day?");
            birthdayDays.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine();

            foreach (int day in birthdayDays)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();

            Console.WriteLine("What's your birthday day?");
            int uday = int.Parse(Console.ReadLine());
            birthdayDays.Add(uday);
            birthdayDays.RemoveAt(0);

            Console.WriteLine( );
            Console.WriteLine(birthdayDays.Count);
            Console.WriteLine();

            foreach (int day in birthdayDays)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine();








        }
    }
}
