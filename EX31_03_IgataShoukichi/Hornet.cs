using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31
{
    class Hornet : Character
    {
        public Hornet(string name, float hp, float power, bool animal) : base(name, hp, power, animal) { }
        public override void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}に向け毒針を刺した！");
            if (destination.Animal)
            {
                Console.WriteLine($"{destination.name}は毒状態になった！");
                Console.WriteLine($"{destination.name}は毒で倒れてしまった");
                destination.hp -= destination.hp;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
                if (destination.hp <= 0)
                {
                    Console.WriteLine($"{destination.name}はもう戦えない。");
                }
            }
            else
            {
                Console.WriteLine($"{destination.name}は無傷だ！");
            }
        }
    }
}
