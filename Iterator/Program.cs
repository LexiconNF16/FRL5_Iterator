using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explicit loop
            //var enumerator = Naturals().GetEnumerator();
            //Console.WriteLine(enumerator.Current);
            //while (enumerator.MoveNext()) {
            //    Console.WriteLine(enumerator.Current);
            //    Console.ReadLine();
            //}

            // LimitedList
            var backPack = new LimitedList<string>(10);

            bool added;
            int count = 0;
            do
            {
                count += 1;
                added = backPack.Add($"item {count}");
            } while (added);
            Inventory(backPack);
            Console.ReadKey(true);

            count = 0;
            string remove = null;
            foreach (var item in backPack)
            {
                if (count == 3)
                {
                    remove = item;
                }
                count += 1;
            }
            backPack.Remove(remove);
            Inventory(backPack);
        }

        private static void Inventory(LimitedList<string> backPack)
        {
            Console.WriteLine();
            Console.WriteLine($"{backPack.Count} items:");
            foreach (var item in backPack)
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<int> Naturals()
        {
            int i = 7;
            while (true)
            {
                yield return i;
                i += 1;
            }
        }
    }
}
