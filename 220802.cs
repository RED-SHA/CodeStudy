using System;

namespace CodeStd
{
    class Program
    {

        static void EX_9498()
        {
            // 9498 :: 시험 점수를 입력받아 90 ~ 100점은 A, 80 ~ 89점은 B, 70 ~ 79점은 C, 60 ~ 69점은 D, 나머지 점수는 F를 출력하는 프로그램을 작성하시오.
            string s = Console.ReadLine();
            int i = int.Parse(s);
            if (90 <= i && i <= 100)
            {
                Console.WriteLine("A");
            }
            else if (80 <= i && i <= 89)
            {
                Console.WriteLine("B");
            }
            else if (70 <= i && i <= 79)
            {
                Console.WriteLine("C");
            }
            else if (60 <= i && i <= 69)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }

        static void EX_2753()
        {
            //연도가 4의 배수이면서, 100의 배수가 아닐 때 또는 400의 배수일 때 1 반환, 아니면 0 반환
            string s = Console.ReadLine();
            int i = int.Parse(s);

            if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        static void EX_2884()
        {
            //원래 설정되어 있는 알람을 45분 앞서는 시간으로 바꾸는 것이다.
            string[] s = Console.ReadLine().Split();
            int[] i = { int.Parse(s[0]), int.Parse(s[1]) };

            i[1] -= 45;
            if (i[1] < 0)
            {
                i[1] += 60;
                i[0]--;
                if (i[0] < 0)
                {
                    i[0] += 24;
                }
            }
            Console.Write(i[0]);
            Console.WriteLine(" " + i[1]);
        }

        static void EX_2525()
        {
            //시작하는 시각과 오븐구이를 하는 데 필요한 시간이 분단위로 주어졌을 때, 오븐구이가 끝나는 시각을 계산하는 프로그램을 작성하시오.
            string[] s = Console.ReadLine().Split();
            int[] i = { int.Parse(s[0]), int.Parse(s[1]) };
            string s1 = Console.ReadLine();
            int i1 = int.Parse(s1);

            i[1] += i1;
            if (i[1] >= 60)
            {
                while (i[1] >= 60)
                {
                    i[1] -= 60;
                    i[0]++;
                }
                if (i[0] >= 24)
                {
                    i[0] -= 24;
                }
            }
            Console.Write(i[0]);
            Console.WriteLine(" " + i[1]);
        }

        static void EX_2480()
        {
            //같은 눈이 3개가 나오면 10,000원 + (같은 눈)×1,000원의 상금을 받게 된다. 
            //같은 눈이 2개만 나오는 경우에는 1,000원 + (같은 눈)×100원의 상금을 받게 된다. 
            //모두 다른 눈이 나오는 경우에는(그 중 가장 큰 눈)×100원의 상금을 받게 된다.
            string[] s = Console.ReadLine().Split();
            int[] i = { int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]) };

            if (i[0] == i[1] && i[1] == i[2])
            {
                Console.WriteLine(10000 + i[0] * 1000);
            }
            else if (i[0] == i[1] || i[0] == i[2] || i[1] == i[2])
            {
                if (i[0] == i[1])
                {
                    Console.WriteLine(1000 + i[0] * 100);
                }
                else
                    Console.WriteLine(1000 + i[2] * 100);
            }
            else
            {
                int idx = 0;
                foreach (var item in i)
                {
                    if (idx < item)
                    {
                        idx = item;
                    }
                }
                Console.WriteLine(idx * 100);
            }

        }


        static void Main(string[] args)
        {
            int nbr = 4;
            switch (nbr)
            {
                case 0:
                    EX_9498();
                    break;

                case 1:
                    EX_2753();
                    break;

                case 2:
                    EX_2884();
                    break;

                case 3:
                    EX_2525();
                    break;

                case 4:
                    EX_2480();
                    break;

                default:
                    break;
            }
        }
    }
}
