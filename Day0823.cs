using System;
using System.Collections.Generic;
using System.Text;

namespace CodeStd
{
    class Day0823
    {
        public static void EX_10872()
        {
            int input = int.Parse(Console.ReadLine());
            int rst = 1;

            for (; input > 0; input--)
            {
                rst *= input;
            }

            Console.WriteLine(rst);
        }

        public static void EX_10870()
        {
            int input = int.Parse(Console.ReadLine());

            int fibonacci(int n)
            {
                if (n == 1 || n == 2) return 1;
                else return fibonacci(n - 1) + fibonacci(n - 2);
            }

            if (input == 0)
            {
                Console.WriteLine("0");
                return;
            }

            Console.WriteLine(fibonacci(input));
        }

        public static void EX_17478()
        {
            int idx = int.Parse(Console.ReadLine());

            Console.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");


            void recur(int nbr)
            {
                string a = "";
                for (int i = 0; i < nbr * 4; i++)
                {
                    a += "_";
                }
                if (nbr == idx)
                {
                    Console.WriteLine($"{a}\"재귀함수가 뭔가요?\"");
                    Console.WriteLine($"{a}\"재귀함수는 자기 자신을 호출하는 함수라네\"");
                    return;
                }
                Console.WriteLine($"{a}\"재귀함수가 뭔가요?\"");
                Console.WriteLine($"{a}\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.");
                Console.WriteLine($"{a}마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.");
                Console.WriteLine($"{a}그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"");
                recur(nbr + 1);
            }

            void recur2(int idx)
            {
                if (idx == 0)
                {
                    Console.WriteLine($"라고 답변하였지.");
                    return;
                }
                string a = "";
                for (int i = 0; i < idx * 4; i++)
                {
                    a += "_";
                }
                Console.WriteLine($"{a}라고 답변하였지.");
                recur2(idx - 1);
            }

            recur(0);
            recur2(idx);

        }
    }
}
