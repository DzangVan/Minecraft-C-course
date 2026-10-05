using System;

namespace Program
{
    class Block
    {
        public string Material;         // поле: из чего блок (алмаз, дерево, камень)
        public int X, Y, Z;             // поле: координаты в мире
        public void Place()             // метод: поставить блок
        {
            Console.WriteLine($"Поставлен {Material} - блок на ({X},{Y},{Z})");

        }
    }

    class Item
    {
        public string Name;
        public int Count;
        public void ShowInfo()
        {
            Console.WriteLine($"В инвентаре {Count}{Name}");
        }
    }

    class Program
    {
        static void Main()
        {
                // Пример из дипсика 
            Block diamond = new Block();        //создаём обьект - конкретный блок
            diamond.Material = "Алмаз";
            diamond.X = 0;
            diamond.Y = 0;
            diamond.Z = 0;
            diamond.Place();                    // Поставлен Алмаз-Блок на (0,0,0,)

        //Задача 1 установленная по этому уроку.

            Item Apple = new Item();            //создаём обьект - конкретный предмет
            Apple.Count = 5;
            Apple.Name = "Яблоко";
            Apple.ShowInfo();                   // В инвентаре 5 яблок

        }
    }


}