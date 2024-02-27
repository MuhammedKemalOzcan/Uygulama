using System.Runtime.InteropServices;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Lütfen Pozitif bir sayı giriniz:");
            int n = int.Parse(Console.ReadLine());
            string[] kelime = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. Kelimeyi giriniz:", i + 1);
                kelime[i] = Console.ReadLine();
            }
            Array.Reverse(kelime);
            foreach (string k in kelime)
            {
                Console.Write(k + " ");
            }
        }
        static void Task2() 
        {
            Console.WriteLine("Please enter a sentence:");
            string text = Console.ReadLine();

            int wordCount = 0;
            int letterCount = 0;
            bool inWord = false;
            foreach (var i in text)
            {
                if (char.IsLetter(i))
                {
                    letterCount++;
                }
            }
            foreach (char c in text)
            {
                if (char.IsWhiteSpace(c))
                {
                    inWord = false;
                }
                else if (!inWord)
                {
                    inWord = true;
                    wordCount++;
                }
            }

            Console.WriteLine("Word Count: " + wordCount);
            Console.WriteLine("Letter Count: " + letterCount);


        }

        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine();
            Task2();
            

        }
    }
}
