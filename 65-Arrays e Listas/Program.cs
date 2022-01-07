using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploColecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var nums2 = new ArrayList() { 21, 22, 23, 24 };
            nums.Add(11);
            nums.Insert(3, 999);
            nums.Remove(4);
            nums[7] = 888;
            nums.AddRange(nums2);
            nums.Add(77);
            nums.Add(99);
            // nums.Add("abc"); // object
            foreach (int n in nums)
                Console.WriteLine(n);
            Console.WriteLine("Capacidade:" + nums.Capacity);
            Console.WriteLine("Num. itens: " + nums.Count);
            Console.WriteLine("Posição do num 999 no array: " + nums.IndexOf(999));
            var qry = from int n in nums
                      where n % 2 == 0
                      select n;
            foreach (int n in qry)
                Console.WriteLine(n);
        }

        private static void ExemploVetores()
        {
            int[] nums = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int n in nums)
                Console.WriteLine(n);
            for (int i = 0; i <= 9; i++)
                Console.WriteLine(nums[i]);
        }
    }
}
