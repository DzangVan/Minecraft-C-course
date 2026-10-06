using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCourse.Lessons.Lessons
{
    internal class Less2
    {
        //Lesson 2
        class Player
        {
            private int hearts;                 // мнимое Здоровье игрока
            public string Name { get; set; } = "";   // Имя игрока свободно задаваемое | изменяемое 
            public int Hearts                   // Фактическое здоровья игрока
            {
                get => hearts;
                set
                {
                    if (value < 0 || value > 20)
                        throw new ArgumentException("HP не может быть больше 20 или меньшше 0 !");
                    hearts = value;
                }
            }
            public void Player_Info()
            {
                Console.WriteLine($"У игрока {Name} {hearts} HP");
            }
        }

        
        public static class L02_Player
        {
            public static void Run()
            {
                Console.WriteLine("=== Урок 2: Инкапсуляция ===\b");
                var Steve = new Player { Name = "Steve", Hearts = 20 };
                Steve.Player_Info();
                //Console.WriteLine($"{Steve.Name}: {Steve.Hearts} Hp ");

                try
                {
                    Steve.Hearts = 20;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                
            }


        }
    }
}
