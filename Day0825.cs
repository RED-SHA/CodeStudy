using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeStd
{
    public static class Day0825
    {
        public static void EX_2798()
        {
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxVal = a[1];
            int crnVal = 0;
            int crnMaxVal = 0;

            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    for (int k = 0; k < b.Length; k++)
                    {
                        if (j == k || i == k)
                        {
                            continue;
                        }

                        crnVal = b[i] + b[j] + b[k];

                        if (maxVal >= crnVal && crnVal > crnMaxVal)
                        {
                            crnMaxVal = crnVal;
                        }
                    }
                }
            }
            Console.WriteLine(crnMaxVal);
            return;
        }

        public static void EX_2231()
        {
            int input = int.Parse(Console.ReadLine());
            int tenIdx = input.ToString().Length;
            int calNbr = input - tenIdx * 9;
            int rstNbr = 0;

            for (; calNbr < input; calNbr++)
            {
                string calString = calNbr.ToString();
                rstNbr = calNbr;
                for (int i = 0; i < calString.Length; i++)
                {
                    rstNbr += (calString[i] - '0');
                }
                if (input == rstNbr)
                {
                    Console.WriteLine(calNbr);
                    return;
                }
            }
            if (input != rstNbr)
            {
                Console.WriteLine("0");
                return;
            }
        }
        public static void EX_7568()
        {
            int argc = int.Parse(Console.ReadLine());
            List<int[]> info = new List<int[]>();
            int[,] argv = new int[argc, 2];
            for (int i = 0; i < argc; i++)
            {
                int[] contents = Console.ReadLine().Split().Select(int.Parse).ToArray();

                info.Add(contents);
            }
            info.Sort();

        }
        public static void EX_1()
        {

        }


    }
}
