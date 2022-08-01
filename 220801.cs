using System;

namespace CodeStudyy
{
	class Study
    {
        // Hello World 출력
        static void Ex00()
		{
			Console.WriteLine("Hello World!");
		}

        // 개출력
        static void Ex01()
        {
            string[] res = { "|\\_/|", "|q p|   /}", "( 0 )\"\"\"\\", "|\" ^ \"`    |", "||_/=\\\\__|" };
            foreach (var a in res)
            {
                Console.WriteLine(a);
            }
        }

        //두 자연수 A와 B가 주어진다. 이때, A+B, A-B, A*B, A/B(몫), A%B(나머지)를 출력하는 프로그램을 작성하시오. 
        static void Ex02(int A, int B)
        {
            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A * B);
            Console.WriteLine(A / B);
            Console.WriteLine(A % B);
        }

        // 서기 연도를 알아보고 싶은 불기 연도 y가 주어진다. (1000 ≤ y ≤ 3000), 불기 연도를 서기 연도로 변환한 결과를 출력한다.
        static void Ex03(int y)
        {
            int nbr = 2541 - 1998;
            y -= nbr;
            Console.WriteLine(y);
        }

        //첫째 줄에 (1)의 위치에 들어갈 세 자리 자연수가, 둘째 줄에 (2)의 위치에 들어갈 세자리 자연수가 주어진다. 첫째 줄부터 넷째 줄까지 차례대로 (3), (4), (5), (6)에 들어갈 값을 출력한다.
        static void Ex04(string a, string b)
        {
            int[] nbrA = { a[2] - '0', a[1] - '0', a[0] - '0' };
            int[] nbrB = { b[2] - '0', b[1] - '0', b[0] - '0' };
            int[] res = {0, 0, 0};
            int fin = 0;

            for (int i = 0; i < nbrB.Length; i++)
            {
                for (int j = 0; j < nbrA.Length; j++)
                {
                    res[i] += (nbrB[i] * nbrA[j] * ((int)MathF.Pow(10, i)) * ((int)MathF.Pow(10, j)));
                }
            }

            for (int i = 0; i < res.Length; i++)
            {
                fin += res[i];
                Console.WriteLine(res[i] / (int)MathF.Pow(10, i));
            }

            Console.WriteLine(fin);

        }


        static void Main()
        {
            int nbr = 4;
            //string[] s = Console.ReadLine().Split();
            string ss = Console.ReadLine();
            string sss = Console.ReadLine();

            switch (nbr)
            {
                case 0:
                    Ex00();
                    break;

                case 1:
                    Ex01();
                    break;

                case 2:
                    //Ex02(int.Parse(s[0]),int.Parse(s[1]));
                    break;

                case 3:
                   // Ex03(int.Parse(s[0]));
                    break;

                case 4:
                    Ex04(ss, sss);
                    break;

            }

        }

    }



}
