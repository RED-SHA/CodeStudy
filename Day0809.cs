using System;
using System.Collections.Generic;
using System.Text;

namespace CodeStd
{
    class Day0809
    {
        public static void EX4673()
        {
            //양의 정수 n에 대해서 d(n)을 n과 n의 각 자리수를 더하는 함수라고 정의하자. 예를 들어, d(75) = 75+7+5 = 87이다.
            bool[] arr = new bool[20000];

            for (int i = 1; i <= 10000; i++)
            {
                string nbr = i.ToString();
                int rst = 0;

                for (int j = 0; j < nbr.Length; j++)
                {
                    rst += nbr[j] - '0';
                }
                arr[rst + i] = true;
            }

            for (int i = 1; i < 10000; i++)
            {
                if (arr[i] == false)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void EX1065()
        {
            int Input = int.Parse(Console.ReadLine());
            List<string> a = new List<string>();
            if (Input <= 99)
            {
                Console.WriteLine(Input);
            }
            else
            {
                int cnt = 0;
                for (int i = 100; i <= Input; i++)
                {
                    string nbr = i.ToString();
                    bool isWrong = false;
                    int standard = (nbr[1] - '0') - (nbr[0] - '0');
                    for (int j = 0; j < nbr.Length - 1; j++)
                    {
                        if (((nbr[j + 1] - '0') - (nbr[j] - '0')) - standard != 0)
                        {
                            isWrong = true;
                            break;
                        }
                    }
                    if (!isWrong)
                    {
                        cnt++;
                        a.Add(nbr);
                    }
                }

                Console.WriteLine(99 + cnt);
            }
        }

    }
}
