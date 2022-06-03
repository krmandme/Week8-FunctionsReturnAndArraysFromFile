using System;

namespace ChuckNorris
{
	class Program
	{
		static void Main(string[] args)
		{
            string randomChuck;
            randomChuck = GetRandomFromFile("chuck.txt");

            string filePath = @"C:\Users\..\Samples\chuck.txt";

            string[] dataFromFile = System.IO.File.ReadAllLines(filePath);

            Console.WriteLine($"{randomChuck}");



        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;

        }
        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\..\Samples\{fileName}";
            string[] dataFromFile = System.IO.File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }
	}
}
