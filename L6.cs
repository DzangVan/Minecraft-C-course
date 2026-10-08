using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCourse.Lessons.Lessons
{
    internal class Less6
    {
        interface Istorage
        {
            void Store(string item);
        }
        class Chest : Istorage
        {
            public void Store(string item) => Console.WriteLine($"Сундук хранит: {item}\n");
        }
        class EnderChest : Istorage
        {
            public void Store(string item) => Console.WriteLine($"Эндер-сундук хранит: {item}\n");
        }

        interface Icraftable
        {
            void Craft(string craft);
        }
        class Sword : Icraftable
        {
            public void Craft(string craft) => Console.WriteLine($"Меч имеет крафт {craft}\n\t");
        }
        class Pickaxe : Icraftable
        {
            public void Craft(string craft) => Console.WriteLine($"Кирка имеет крафт {craft}\n\t");
        }

        public static class L06_interface
        {
            public static void Run()
            {
                Console.WriteLine("===    Урок 6: Интерфейсы    ===\n");
                Istorage chest = new Chest();
                Console.WriteLine("\t__________Сундук__________");
                Console.WriteLine("\t[] [] [] [] [] [] [] [] []");
                Console.WriteLine("\t[] [] [] [] [] [] [] [] []");
                Console.WriteLine("\t[] [] [] [] [] [] [] [] []\n\t");
                chest.Store("64 Дубовое ревно");
                Istorage Echest = new EnderChest();
                Console.WriteLine("\t_______Эндер-сундук_______");
                Console.WriteLine("\t[] [] [] [] [] [] [] [] []");
                Console.WriteLine("\t[] [] [] [] [] [] [] [] []");
                Console.WriteLine("\t[] [] [] [] [] [] [] [] []\n\t");
                Echest.Store("64 Плод хоруса");

                Icraftable sword = new Sword();
                sword.Craft("\n\t[1][2][3]\tКрафт идёт строго по горизонтали \n\t[4][5][6]\tВ 2,5 слотах материал для меча \n\t[7][8][9]\tВ 8 слоте Палка");

                Icraftable pickaxe = new Pickaxe();
                pickaxe.Craft("\n\t[1][2][3]\tКрафт идёт T-образно \n\t[4][5][6]\tВ 1,2,3 слотах материал кирки \n\t[7][8][9]\tВ 5,8 слотах Палка");


            }
        }
    }
}
