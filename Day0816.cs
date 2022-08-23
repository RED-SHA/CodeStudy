using System;
using System.Collections.Generic;
using System.Text;

namespace CodeStd
{
    static class Day0816
    {
        static List<int> tmp = new List<int>();
        static int temp = int.MaxValue;
        public static int fibonacci(int n, int nbr)
        {
            if (n < 3)
            {
                //if (n == 0) tmp.Add(nbr);
                if (n == 0 && temp > nbr)
                {
                    temp = nbr;
                }
                return 0;
            }
            else
            {
                return fibonacci(n - 3, nbr + 1) + fibonacci(n - 5, nbr + 1);
            }

        }

        public static void EX_2839()
        {
            int input = int.Parse(Console.ReadLine());


            int a = fibonacci(input, 0);
            /*            if (tmp.Count == 0)
                            Console.WriteLine("-1");
                        else
                        Console.WriteLine(tmp.Min());
                        */
            if (temp == 0)
                Console.WriteLine("-1");
            else
                Console.WriteLine(temp);
        }

        public static void EX_2839_2()
        {
            int input = int.Parse(Console.ReadLine());
            int Big = 5;
            int Small = 3;

            int rst = 0;

            while (true)
            {
                if (input % Big == 0)
                {
                    rst += input / Big;
                    break;
                }
                else if (input < Small)
                {
                    rst = -1;
                    break;
                }

                input -= Small;
                rst++;
            }

            Console.WriteLine(rst);

        }


        public static void EX_10757()
        {
            string[] s = Console.ReadLine().Split();
            string a = s[0];
            string b = s[1];
            int len = 0;
            int idx = 0;
            List<int> rst = new List<int>();


            int max = (a.Length > b.Length) ? a.Length : b.Length;
            bool isA = (a.Length > b.Length) ? true : false;

            if (isA)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    rst.Add(a[i] - '0');
                }
                int j = 0;
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    rst[rst.Count - 1 - j] += b[i] - '0';
                    j++;
                }
            }
            else
            {
                for (int i = 0; i < b.Length; i++)
                {
                    rst.Add(b[i] - '0');
                }
                int j = 0;
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    rst[rst.Count - 1 - j] += a[i] - '0';
                    j++;
                }
            }

            for (int i = 0; i < rst.Count; i++)
            {
                if (rst[rst.Count - 1 - i] >= 10)
                {
                    if (rst.Count - 2 - i < 0)
                    {
                        rst[rst.Count - 1 - i] -= 10;
                        rst.Insert(0, 1);
                    }
                    else
                    {
                        rst[rst.Count - 1 - i] -= 10;
                        rst[rst.Count - 2 - i] += 1;
                    }
                }

            }

            for (int i = 0; i < rst.Count; i++)
            {
                Console.Write(rst[i]);
            }

        }

        public static void EX_1193()
        {
            //X가 주어졌을 때, X번째 분수를 구하는 프로그램을 작성하시오.
            int input = int.Parse(Console.ReadLine());
            int tmp = input;
            int a = 0;
            int b = 0;
            int cnt = 0;

            for (int i = 1; i < 10000; i++)
            {
                if (tmp <= i)
                {
                    break;
                }
                tmp -= i;
                cnt++;
            }

            if (cnt % 2 == 0)
            {
                a = cnt;
                tmp--;
                for (; tmp > 0; tmp--)
                {
                    a--;
                    b++;
                }
                Console.WriteLine($"{a + 1}/{b + 1}");
            }
            else
            {
                b = cnt;
                tmp--;
                for (; tmp > 0; tmp--)
                {
                    b--;
                    a++;
                }
                Console.WriteLine($"{a + 1}/{b + 1}");
            }
        }


        public static void EX_2775()
        {
            //각각의 Test case에 대해서 해당 집에 거주민 수를 출력하라.

        }
    }
}
