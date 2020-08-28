using System;

namespace crystal_store
{
    class CrystalStore
    {
        static void Main(string[] args)
        {
            int goldCount = 100;
            int crystalPrice = 15;
            int crystalCount = 5;
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
