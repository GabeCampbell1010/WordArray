using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> dic = new Dictionary<string, HashSet<string>>();

            dic.Add("a", new HashSet<string>());

            dic["a"].Add("b");
            dic["a"].Add("c");

            foreach (KeyValuePair<string, HashSet<string>> cell in dic)
            {

                Console.WriteLine("cell: " + cell.Key);
                Console.Write(" dependees: ");
                foreach (string val in cell.Value)
                {
                    Console.Write(val + " ");
                }
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
