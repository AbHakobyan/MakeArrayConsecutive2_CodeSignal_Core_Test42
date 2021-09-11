using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeArrayConsecutive2_CodeSignal_Core_Test42
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 4, 6};
            int res = makeArrayConsecutive2(array);
            Console.WriteLine(res);
        }

        static int makeArrayConsecutive2(int[] statues)
        {
            Array.Sort(statues);
            HashSet<int> result = new HashSet<int>();
            result = statues.ToHashSet();
            for (int i = statues[0]; i < statues[statues.Length - 1]; i++)
            {
                result.Add(i);
            }
            int x = result.Count;
            int y = statues.Length;
            int res = x - y;
            return res;
        }
    }
}
