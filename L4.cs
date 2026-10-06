using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCourse.Lessons.Lessons
{
    internal class Less4
    {
        class Entity
        {
            public string Name { get; }
            public int Damage { get; }
            public Entity(string name) 
            { 
                Name = name; 
            }
            public Entity(int damage)
            {
                Damage = damage;
            }
            public Entity(string name, int damage)
            {
                Name = name;
                Damage = damage;
            }
            public virtual void Greet() => Console.WriteLine($"Я сущность {Name}, с базовым Уроном: {Damage}");
        }

        class Player : Entity                                           // Player наследует Entity
        {
            public string Skin { get; }
            public string[] Invent { get; }
            public Player(string name, string skin, int damage) : base(name, damage)        // вызываем конструктор родителя
            {
                Skin = skin;
            }
            public override void Greet() =>
                Console.WriteLine($"Я игрок {Name}, скин: {Skin}, урон {Damage}");
        }

        class Zombie : Entity
        {
            public int Damage { get; }
            public Zombie(int damage) : base( damage)
            {
                Damage = damage;
            }
            public override void Greet()
            {
                Console.WriteLine($"Сущность Зомби. Урон: {Damage}");
            }
        }

        public static class L04_Entity
        {

            public static void Run()
            {
                Console.WriteLine("=== Урок 4: Наследование ===\b");
                Entity p = new Player("Steve", "default", 1);
                p.Greet();
                // Я игрок Steve, скин: default , урон 1
                Entity z = new Zombie(-4);
                z.Greet();
            }


        }
    }
}
