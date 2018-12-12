using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTextAdventure
{
    public class AttributeGenerator
    {
        Random myRNG = new Random();
        public Hero Generate(Hero myHero)
        {
            myHero.Strength = myRNG.Next(1, 21);
            if (myHero.HeroClass.ToLower() == "warrior")
                myHero.Strength = myHero.Strength + 3;
            else if (myHero.HeroClass.ToLower() == "wizard")
                myHero.Strength = myHero.Strength - 3;
            myHero.Intelligence = myRNG.Next(1, 21);
            myHero.Dexterity = myRNG.Next(1, 21);
            myHero.Wisdom = myRNG.Next(1, 21);
            myHero.Charisma = myRNG.Next(1, 21);
            myHero.Constitution = myRNG.Next(1, 21);
            myHero.HitPoints = (myHero.Strength + myHero.Constitution) / 2;
            return myHero;
        }
    }
}
