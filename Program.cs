using System;

namespace crystal_store
{
    class CrystalStore
    {
        static void Main(string[] args)
        {
            int crystalPrice = 15;
            int goldCount = Console.ReadLine("Введите количество золота: ");
            int crystalCount = Console.ReadLine("Сколько кристалов вы хотите купить?: "); ;

            if (goldCount - crystalPrice * crystalCount >= 0)
            {
                 Console.WriteLine("Вы купили " + crystalCount + 
                     " кристаллов, у вас осталось " + 
                     (goldCount - crystalPrice * crystalCount) + " единиц золота!");
            }
                else
            {
                Console.WriteLine("У вас недостаточно золота для этой покупки");
            }
        }
    }
}
