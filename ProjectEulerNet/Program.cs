using System;

namespace ProjectEulerNet
{
    class Program
    {
        /// <summary>
        /// https://blog.usejournal.com/consider-yourself-a-developer-you-should-solve-the-project-euler-problems-ed8d13397c9c
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Greet();
        }

        private static void Greet()
        {
            Console.WriteLine("Welcome to my Project Euler solutions repo.");
            Console.WriteLine("My name is Mattan Margalith, a software developer in a company called Synect,");
            Console.WriteLine("you can read about us at http://www.synectmedia.com.");
            Console.WriteLine("\nA few weeks ago I came across a Medium article advocating for solving the first 50 Project Euler problems.");
            Console.WriteLine("\nAs I never previously heard of this project, I quickly signed up started tackling these problems..");
            Console.WriteLine("\nAs the article notes, it's against the competition to post solutions. However, as the first 50-100 questions have been solved by 100k+ developers, and solutions are widely available online, it is ok and recommended to post those solutions.");
            Console.WriteLine("\nSo there we are.. I hope you find this useful, feel free to send your comments and feedback.");
            Console.WriteLine("\nPlease remember, these are my solutions and not anyone's else. There might be a better solution, hell, a quick google search could potentially find you a better solution than mine..)");
            Console.WriteLine("The code posted here is for reference, education, and assistance to those of you out there that need it.");
            Console.WriteLine("\nFeel free to check out my website at https://mattanm.com, or follow me on Twitter at @MattanGuitar.");
            Console.WriteLine("\nCheers and good luck!");
            Console.WriteLine("\nMattan.");
            Console.ReadKey();
        }
    }
}
