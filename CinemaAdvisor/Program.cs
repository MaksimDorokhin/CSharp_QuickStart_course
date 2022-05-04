using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAdvisor
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Hi, dear friend! This program help you for selection movie for evening ");
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name);
            Console.WriteLine("genres of movies ");
            Console.WriteLine("1 . comedy");
            Console.WriteLine("2 . fantastic");
            Console.WriteLine("3 . drama");
            Console.WriteLine("4 . thriller");
            Console.WriteLine("5 . action");
            Console.Write("What you choose: ");
            int genre = Int32.Parse(Console.ReadLine());
            Console.WriteLine("In that case, I recommend the following list");
            if (genre == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The mask");
                Console.WriteLine("Bruce Almighty");
                Console.WriteLine("Bachelor Party Vegas");
            }
            else if (genre == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("the men X");
                Console.WriteLine("Planet of the Apes");
            }
            else if (genre == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("The Green Mile");
                Console.WriteLine("Titanic");
            }
            else if (genre == 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Morbius  ");
                Console.WriteLine("Stranger Things");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Die Hard");
                Console.WriteLine("resident evil movie");
            }
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
	}
}
