using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCourse.Lessons.Lessons
{
    internal class Less3
    {
        class Tool
        {
            public string Tool_Name { get; }
            public int Durability { get; }
            public Tool(string tool_name, int durability)
            {
                Tool_Name = tool_name;
                Durability = durability;
            }

            public Tool(string tool_name) : this(tool_name, GetDefaultDurability(tool_name)) { }

            private static int GetDefaultDurability(string name)
            {
                if (name.Contains("золот", StringComparison.OrdinalIgnoreCase)) return 33;
                if (name.Contains("деревянн", StringComparison.OrdinalIgnoreCase)) return 59;
                if (name.Contains("каменн", StringComparison.OrdinalIgnoreCase)) return 131;
                if (name.Contains("медн", StringComparison.OrdinalIgnoreCase)) return 190;
                if (name.Contains("железн", StringComparison.OrdinalIgnoreCase)) return 250;
                if (name.Contains("алмазн", StringComparison.OrdinalIgnoreCase)) return 1561;
                if (name.Contains("незеритов", StringComparison.OrdinalIgnoreCase)) return 2031;
                return -1;      // неразрушимый
                                // новая перегрузка : по умолчанию. если предмет не определиться по типу, будет определён в тип с прочностью -1 , что по факту делает его не разрушимым
            }

            public void Tool_Info() => Console.WriteLine($"{Tool_Name}, прочность {Durability}");

        }
        public static class L03_Tool
        {
            public static void Run()
            {
                Console.WriteLine("=== Урок 3: Конструкторы ===\b");

                var Stick = new Tool("Палка");
                // Палка, -1 ед. прочности/неразрушима           =>          -1 по перегрузке
                var Diamond_Pickaxe = new Tool("Алмазная кирка", 1561);
                // Алмазная Кирка, 1561 ед. прочности
                Stick.Tool_Info();
                Diamond_Pickaxe.Tool_Info();

            }
            public static void InvInfo()
            {
                var Stick = new Tool("Палка");
                // Палка, -1 ед. прочности/неразрушима           =>          -1 по перегрузке
                var Diamond_Pickaxe = new Tool("Алмазная кирка", 1561);
                // Алмазная Кирка, 1561 ед. прочности
                Console.Write($"{Stick} {Diamond_Pickaxe}");
            }
        }
    }
}
