using System;

namespace _11._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int xp = 10; int reward = 5; int threshold = 15; bool success = false;
            Console.WriteLine("Character - " + xp + "/" + threshold + "xp for next level");
            Console.WriteLine("Attack the monster in front of you? y/n");
            string izbor = Console.ReadLine();
            if (izbor == "y")
            {
                Console.WriteLine("You killed the mosnter... +" + reward + " expirience!");
                if (xp + reward >= threshold)
                {
                    success = true;
                }
                else 
                {

                }
            }
            else if (izbor == "n")
            {
                Console.WriteLine("It killed your pacifist ass.");
            }
            else
            {
                Console.WriteLine("It killed you before you could do anything.");
            }
            Console.WriteLine(success);
           
        }
    }
}
