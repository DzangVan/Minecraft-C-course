using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCourse.Lessons.Lessons
{
    internal class Less5
    {
        abstract class Mob
        {
            public abstract int GetDamage();
            public abstract string GetNBT();
        }
        class Zombie : Mob
        {
            public override int GetDamage() => 2;
            public override string GetNBT() => "Зомби";
            
        }
        class Skeleton : Mob
        {
            public override int GetDamage() => 1;
            public override string GetNBT() => "Скелет";
        }
        class Creeper : Mob
        {
            public override int GetDamage() => 20;
            public override string GetNBT() => "Крипер";
        }
        class Spider : Mob
        {
            public override int GetDamage() => 2;
            public override string GetNBT() => "Паук";
        }

        public static class L05_Mob
        {
            public static void Run()
            {
                Console.WriteLine("=== Урок 5: Полиморфия ===\b");
                Mob[] mobs = {new Zombie(), new Skeleton(), new Creeper(), new Spider()};
                foreach (var m in mobs)
                {
                    if (m.GetNBT() == "Зомби")
                    {
                        Console.WriteLine($"Это Зомби его урон {m.GetDamage()}");
                    }
                    else if (m.GetNBT() == "Скелет")
                    {
                        Console.WriteLine($"Это Скелет его урон {m.GetDamage()}");
                    }
                    else if (m.GetNBT() == "Крипер")
                    {
                        Console.WriteLine($"Это Крипер его урон {m.GetDamage()}");
                    }
                    else if (m.GetNBT() == "Паук")
                    {
                        Console.WriteLine($"Это Паук его урон {m.GetDamage()}");
                    }
                }
            }
        }
    }
}
