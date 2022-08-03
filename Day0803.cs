using System;
using System.Collections.Generic;
using System.Text;

namespace CodeStd
{
    class Day0803
    {
        static void EX_1110()
        {

            /* 26부터 시작한다.
             * 2 + 6 = 8 => 68이다. 6 + 8 = 14 => 84이다. 8 + 4 = 12 => 42이다. 4 + 2 = 6 => 26이다.
             *            위의 예는 4번만에 원래 수로 돌아올 수 있다. 따라서 26의 사이클의 길이는 4이다.
             *            N이 주어졌을 때, N의 사이클의 길이를 구하는 프로그램을 작성하시오.*/
            //int[] rst = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int input = int.Parse(Console.ReadLine());
            int result = input;
            int count = 0;

            while (input != result || count == 0)
            {
                count++;
                int[] nbrArr = { result / 10, result % 10 };
                result = nbrArr[0] + nbrArr[1];
                int[] nbr2Arr = { result / 10, result % 10 };
                result = nbrArr[1] * 10 + nbr2Arr[1];
            }

            Console.WriteLine(count);
        }

        static void EX_10871()
        {
            //정수 N개로 이루어진 수열 A와 정수 X가 주어진다. 이때, A에서 X보다 작은 수를 모두 출력하는 프로그램을 작성하시오.
            int[] rst = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] rst1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int i = 0;
            foreach (var o in rst1)
            {
                if (o < rst[1])
                {
                    if (i != 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(o);
                    i++;
                }
            }
        }
        static void EX_2439()
        {
            //첫째 줄에는 별 1개, 둘째 줄에는 별 2개, N번째 줄에는 별 N개를 찍는 문제
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                for (int j = 0; j < input - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                if (i != input)
                {
                    Console.WriteLine();
                }
            }
        }
        static void EX_11022()
        {
            int input = int.Parse(Console.ReadLine());
            int[][] inputs = new int[input][];
            int i = 0;
            for (i = 0; i < input; i++)
            {
                int[] rst = Console.ReadLine().Split().Select(int.Parse).ToArray();
                inputs[i] = rst;
            }
            i = 0;
            foreach (var item in inputs)
            {
                Console.WriteLine($"Case #{i + 1}: {inputs[i][0]} + {inputs[i][1]} = {inputs[i][0] + inputs[i][1]}");
                i++;
            }
        }
        static void EX_2742()
        {
            int input = int.Parse(Console.ReadLine());
            StringBuilder allNumers = new StringBuilder();

            for (int i = input; i > 0; i--)
            {
                allNumers.Append(i + "\n");
            }
            Console.WriteLine(allNumers);
        }
    }
}
