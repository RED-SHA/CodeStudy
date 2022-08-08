using System;
using System.Collections.Generic;
using System.Text;

namespace CodeStd
{
    class Day0808
    {

        public static void EX2577()
        {
            //세 개의 자연수 A, B, C가 주어질 때 A × B × C를 계산한 결과에 0부터 9까지 각각의 숫자가 몇 번씩 쓰였는지를 구하는 프로그램을 작성하시오.

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            string Rst = (A * B * C).ToString();
            int[] Cnt = new int[10];

            for (int i = 0; i < Rst.Length; i++)
            {
                Cnt[Rst[i] - '0']++;
            }
            for (int i = 0; i < Cnt.Length; i++)
            {
                Console.WriteLine(Cnt[i]);
            }
        }

        public static void EX3052()
        {
            //수 10개를 입력받은 뒤, 이를 42로 나눈 나머지를 구한다. 그 다음 서로 다른 값이 몇 개 있는지 출력하는 프로그램을 작성하시오.

            int[] A = new int[10];
            int[] Cnt = new int[42];
            int Res = 0;

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
                Cnt[A[i] % 42]++;
            }
            for (int i = 0; i < Cnt.Length; i++)
            {
                if (Cnt[i] != 0)
                {
                    Res++;
                }
            }
            Console.WriteLine(Res);
        }

        public static void EX1546()
        {
            //최댓값을 골랐다. 이 값을 M이라고 한다. 그리고 나서 모든 점수를 점수/M*100으로 고쳤다.
            int N = int.Parse(Console.ReadLine());
            string[] NN = Console.ReadLine().Split();

            float Best = 0;
            float Rev = 0;
            List<float> Sub = new List<float>();

            for (int i = 0; i < N; i++)
            {
                Sub.Add(int.Parse(NN[i]));
            }

            for (int i = 0; i < Sub.Count; i++)
            {
                if (Best <= Sub[i])
                {
                    Best = Sub[i];
                }
            }

            for (int i = 0; i < Sub.Count; i++)
            {
                Sub[i] = (Sub[i] / Best) * 100;
                Rev += Sub[i];
            }

            if (Rev / Sub.Count % 1 == 0)
            {
                Console.WriteLine($"{Rev / Sub.Count}.0");
            }
            else
                Console.WriteLine(Rev / Sub.Count);

        }

        public static void EX8958()
        {
            //첫째 줄에 테스트 케이스의 개수가 주어진다. 각 테스트 케이스는 한 줄로 이루어져 있고, 길이가 0보다 크고 80보다 작은 문자열이 주어진다. 문자열은 O와 X만으로 이루어져 있다.
            int N = int.Parse(Console.ReadLine());
            int tmp = 0;
            int rst = 0;
            List<string> Input = new List<string>();

            for (int i = 0; i < N; i++)
            {
                Input.Add(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < Input[i].Length; j++)
                {
                    if (Input[i][j] == 'O')
                    {
                        while (j < Input[i].Length && Input[i][j] == 'O')
                        {
                            tmp++;
                            rst += tmp;
                            j++;
                        }
                        tmp = 0;
                    }
                }
                Console.WriteLine(rst);
                rst = 0;
                tmp = 0;
            }

        }
        public static void EX10818()
        {
            //N개의 정수가 주어진다. 이때, 최솟값과 최댓값을 구하는 프로그램을 작성하시오.
            int a = int.Parse(Console.ReadLine());
            string[] aa = Console.ReadLine().Split();
            List<int> aaa = new List<int>();

            for (int i = 0; i < a; i++)
            {
                aaa.Add(int.Parse(aa[i]));
            }

            int high = aaa[0];
            int low = aaa[0];

            for (int i = 0; i < a; i++)
            {
                if (aaa[i] >= high)
                {
                    high = aaa[i];
                }

                if (aaa[i] <= low)
                {
                    low = aaa[i];
                }
            }

            Console.WriteLine($"{low} {high}");
        }

    }
}
