using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            IEnumerable<string> LFruits = from fruit in fruits 
            where fruit.StartsWith("L")
            select fruit;

            foreach (string f in LFruits)
            {
            Console.WriteLine(f);  
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers
            .Where(num => num % 4 == 0)
            .Where(num => num % 6 == 0);

            foreach (int n in fourSixMultiples)
            {
            Console.WriteLine(n);  
            }
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> descend = names.OrderByDescending(x => x).ToList();
            foreach (string x in descend)
            {
            Console.WriteLine(x);  
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> ascNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            List<int> makeAsc = ascNumbers.OrderBy(x => x).ToList();
            foreach (int x in makeAsc)
            {
            Console.WriteLine(x);  
            }

            // Output how many numbers are in this list
            List<int> countNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            Console.WriteLine($"There are {countNumbers.Count()} numbers in the list");

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            double sum = purchases.Sum();
            Console.WriteLine($"Profit: {sum}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            double bigly = prices.Max();
            Console.WriteLine($"Most Bigly (DoubleBigly): {bigly}");
            
        }
    }
}