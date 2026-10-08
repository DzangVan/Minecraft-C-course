using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCourse.Lessons.Lessons
{
    internal class Less7
    {
        class BLock
        {
            public static int TotalBlocks = 0;      // общее число блоков в мире
            public BLock() { TotalBlocks++; }
            public static void TotalBlockStat()
            {
                int totalblocks;
                totalblocks = TotalBlocks;
                Console.WriteLine($"Всего блоков в мире: {totalblocks}");

            }
        }

        //class Recipe
        //{
        //    public static string craft { get; }
        //    public void Craft(string item)     // Создан метод Craft для item с последующим выводом
        //    {
        //        item = craft;
        //        Console.WriteLine($"Крафтим: {item}");
        //    }
        //    public Recipe(string item)
        //    {
        //    }
        //}

        class Recipe
        {
            public static void Craft(string item)
            {
                Console.WriteLine($"Крафтим {item}");
            }
        }

        //class Pickaxe : Recipe
        //{
        //    public override string Crafting(string[] craft);
        //}

        public static class L07_StaticMember
        {
            public static void Run()
            {
                Console.WriteLine("===    Урок 7: Статические члены    ===\n");
                new BLock(); new BLock(); new BLock(); new BLock(); new BLock(); new BLock(); new BLock(); new BLock(); new BLock(); new BLock();
                BLock.TotalBlockStat();
                //Recipe R = { new Recipe("Алмазный шлем "), new Recipe("Алмазный нагрудник "), new Recipe("Алмазные поножи "), new Recipe("Алмазные ботинки ") };                                           // просто вызов класса Recipe 
                //Console.WriteLine(Recipe.Craft("Алмазные ботинки"));    // Выводим от класса и его метода в скобках информация о {item}
                Recipe.Craft("Алмазный шлем"); 

            }
        }
    }
}
