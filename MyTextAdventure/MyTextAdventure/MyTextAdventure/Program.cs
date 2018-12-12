using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your character's name?");
            string name = Console.ReadLine();
            Hero myAwsomeHero = new Hero(name);
            Console.WriteLine("What's your character's race");
            string race = Console.ReadLine();
            myAwsomeHero.Race = race;
            Console.WriteLine("What's your character's class");
            string heroClass = Console.ReadLine();
            myAwsomeHero.HeroClass = heroClass;
            AttributeGenerator at = new AttributeGenerator();
            myAwsomeHero = at.Generate(myAwsomeHero);
            myAwsomeHero.ToString();
            Console.WriteLine(myAwsomeHero.ToString());
            Console.ReadKey();
        }
    }
}
