using System;

namespace PickRandomFromFile
{
	class Program
	{
		static void Main(string[] args)
		{

            string randomFood, randomDrink, randomMovie;
            randomFood = GetRandomFromFile("foods.txt");
            randomDrink = GetRandomFromFile("drinks.txt");
            randomMovie = GetRandomFromFile("movies.txt");


            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie}. ");

            string filePath = $@"C:\Users\...\samples\foods.txt";

            string[] dataFromFile = System.IO.File.ReadAllLines(filePath);
        }


        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\...\Samples\{fileName}";
            string[] dataFromFile = System.IO.File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;

        }
	}
}
