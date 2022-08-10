using System;
using System.Collections.Generic;
using System.Text;

namespace CodeStd
{
    class Day0810
    {
        public static void EX11654()
        {
            //알파벳 소문자, 대문자, 숫자 0-9중 하나가 주어졌을 때, 주어진 글자의 아스키 코드값을 출력하는 프로그램을 작성하시오.
            string str = Console.ReadLine();
            char chr = str[0];
            if (('0' <= chr && chr <= '9') || ('a' <= chr && chr <= 'z') || ('A' <= chr && chr <= 'Z'))
            {
                Console.WriteLine((int)chr);
            }
        }

        public static void EX5622()
        {
            // 전화 번호를 각 숫자에 해당하는 문자로 외운다. 즉, 어떤 단어를 걸 때, 각 알파벳에 해당하는 숫자를 걸면 된다. 예를 들어, UNUCIC는 868242와 같다. 할머니가 외운 단어가 주어졌을 때, 이 전화를 걸기 위해서 필요한 최소 시간을 구하는 프로그램을 작성하시오.
            string str = Console.ReadLine();
            int rst = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ('P' <= str[i])
                {
                    if ('W' <= str[i])
                    {
                        rst += 10;
                    }
                    else if ('T' <= str[i])
                    {
                        rst += 9;
                    }
                    else
                    {
                        rst += 8;
                    }
                }
                else
                {
                    int tmpp = str[i] - 'A';
                    int tmp = 0;

                    tmpp -= 3;
                    while (tmpp >= 0)
                    {
                        tmpp -= 3;
                        tmp++;
                    }
                    rst += tmp + 3;
                }
            }
            Console.WriteLine(rst);
        }


        public static void EX2941()
        {
            //입력으로 주어진 단어가 몇 개의 크로아티아 알파벳으로 이루어져 있는지 출력한다.

            string str = Console.ReadLine();
            string[] idx = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
            int rst = 0;


            for (int i = 0; i < idx.Length; i++)
            {
                if (str.Contains(idx[i]))
                {
                    str = str.Replace(idx[i], "*");
                }
            }
            rst += str.Length;
            Console.WriteLine(rst);

        }
        public static void EX1157()
        {
            //알파벳 대소문자로 된 단어가 주어지면, 이 단어에서 가장 많이 사용된 알파벳이 무엇인지 알아내는 프로그램을 작성하시오. 단, 대문자와 소문자를 구분하지 않는다.
            string str = Console.ReadLine().ToUpper();
            int[] code = new int[123];
            int best = -1;
            int cnt = 0;

            for (int i = 0; i < str.Length; i++)
            {
                code[str[i]]++;
            }

            for (int i = 0; i < code.Length; i++)
            {
                if (code[i] == code.Max())
                {
                    cnt++;
                    best = i;
                }
                if (cnt > 1)
                {
                    Console.WriteLine("?");
                    return;
                }

            }
            Console.WriteLine((char)best);

        }
        public static void EX10809()
        {
            //알파벳 소문자로만 이루어진 단어 S가 주어진다. 각각의 알파벳에 대해서, 단어에 포함되어 있는 경우에는 처음 등장하는 위치를, 포함되어 있지 않은 경우에는 -1을 출력하는 프로그램을 작성하시오.4
            string str = Console.ReadLine();
            int[] arr = new int[26];

            Array.Fill<int>(arr, -1);
            for (int i = 0; i < str.Length; i++)
            {
                if (arr[str[i] - 'a'] == -1)
                    arr[str[i] - 'a'] = i;
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
