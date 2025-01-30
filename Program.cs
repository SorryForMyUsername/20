using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalComputer pc1 = new PersonalComputer();
            Console.Write("Модель ПК: ");
            pc1.model = Console.ReadLine();
            Console.Write("Тактовая частота процессора: ");
            pc1.clockFrequency = double.Parse(Console.ReadLine());
            Console.Write("Объём оперативной памяти: ");
            pc1.sizeOfRAM = int.Parse(Console.ReadLine());
            Console.Write("Объём жёсткого диска: ");
            pc1.hardDriveCapacity = int.Parse(Console.ReadLine());
            pc1.Info();
            Console.WriteLine();

            PersonalComputer pc2 = new PersonalComputer("Ноутбук");
            Console.WriteLine(pc2);
            Console.WriteLine();

            PersonalComputer pc3 = new PersonalComputer("Настольный", 3.90);
            pc3.sizeOfRAM = 16;
            pc3.hardDriveCapacity = 512;
            pc3.Info();
            Console.WriteLine();

            PersonalComputer pc4 = new PersonalComputer("Моноблок", 2.60, 32);
            Console.WriteLine(pc4);
            Console.WriteLine();

            PersonalComputer pc5 = new PersonalComputer("Планшет", 3.20, 4, 256);
            pc5.Info();

            Console.ReadKey();
        }
    }
}
