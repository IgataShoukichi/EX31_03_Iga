using System;

namespace Ex31
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("しむら人", 50000, 2,true);
            Character character2 = new Character("ささっき", 10000, 25,true);
            Tank tank1 = new Tank("Tiger", 500000, 250,false);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125,false);
            tank2.bullet = 5;
            Cow cow1 = new Cow("牛", 1200000, 90,true);
            Cat cat1 = new Cat("猫", 100000, 1500,true);
            Hornet hornet1=new Hornet("蜂",50,0,true);
            Character[] characters = { character1, character2, tank1, tank2, cow1, cat1,hornet1 };
            for (var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character1);
            }
        }
    }
}