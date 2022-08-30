using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeStd
{
    public static class Day0830
    {
        public static void EX_25305()
        {
            int[] idx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] score = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> Scores = new List<int>();

            foreach (var tgt in score)
            {
                Scores.Add(tgt);
            }

            for (int i = 1; i < idx[1]; i++)
            {
                Scores.Remove(Scores.Max());
            }

            Console.WriteLine(Scores.Max());
        }

        public static void EX_2750()
        {
            int idx = int.Parse(Console.ReadLine());
            List<int> mem = new List<int>();

            for (int i = 0; i < idx; i++)
            {
                mem.Add(int.Parse(Console.ReadLine()));
            }

            mem.Sort();
            foreach (var o in mem)
            {
                Console.WriteLine(o);
            }
        }

        public static void EX_1427()
        {
            string idx = Console.ReadLine();
            List<int> mem = new List<int>();

            for (int i = 0; i < idx.Length; i++)
            {
                mem.Add(idx[i] - '0');
            }

            mem.Sort();
            mem.Reverse();

            foreach (var o in mem)
            {
                Console.Write(o);
            }
            Console.WriteLine();

        }

        public static void EX_15649()
        {
            void Print(List<int> arr)
            {
                foreach (var o in arr)
                {
                    Console.Write(o);
                }
                Console.WriteLine();
            }

            int[] idx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> arr = new List<int>();

            for (int i = 0; i < idx[1]; i++)
            {
                arr.Add(i + 1);
            }

            List<int> all = new List<int>();
            int indicator = 0;

            while (arr[0] != idx[0])
            {
                if (arr[indicator] == idx[0])
                {
                    indicator++;
                }

                for (int i = 0; i <= indicator; i++)
                {
                    arr[arr.Count - 1 - i]--;
                }

            }
        }

    }
