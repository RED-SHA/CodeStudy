using System;
using System.Collections.Generic;
using System.Text;

namespace CodeStd
{
    public static class Day0901
    {
        public static void EX_10815()
        {
            string a = Console.ReadLine();
            Dictionary<int, int> Sangen = Console.ReadLine().Split().Select(int.Parse).ToDictionary((int k) => k, (int v) => 1);
            string c = Console.ReadLine();
            int[] d = Console.ReadLine().Split().Select(int.Parse).ToArray();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < d.Length; i++)
            {
                if (Sangen.ContainsKey(d[i]))
                {
                    sb.Append(1 + " ");
                }
                else
                {
                    sb.Append(0 + " ");
                }
            }
            Console.WriteLine(sb.ToString());

        }

        public static void EX_1764()
        {

            List<string> tmp = new List<string>();
            Dictionary<string, int> A = new Dictionary<string, int>();
            Dictionary<string, int> B = new Dictionary<string, int>();

            StringBuilder sb = new StringBuilder();

            int val = 0;

            int[] idx = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < idx[0]; i++)
            {
                tmp.Add(Console.ReadLine());
            }
            for (int i = 0; i < idx[1]; i++)
            {
                B.Add(Console.ReadLine(), 1);
            }

            tmp.Sort();

            for (int i = 0; i < idx[0]; i++)
            {
                A.Add(tmp[i], 1);
            }

            foreach (var item in A)
            {
                if (B.ContainsKey(item.Key))
                {
                    val++;
                    sb.Append(item.Key + "\n");
                }
            }
            Console.WriteLine(val);
            Console.Write(sb.ToString());
        }


    }
}
