using System;
using System.Collections.Generic;
using System.Linq;

namespace problem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int a = int.Parse(Console.ReadLine());
            //int[] t = new int[10];
            //t = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] n = new int[a];
            //for(int i = 0; i < a; i++)
            //{
            //    n[i] = int.Parse(Console.ReadLine());
            //}

            List<string> deviceNums = new List<string>()
            {
                "9123493342",
                "3123493942",
                "9223433942",
                "3223493942",
                "9223433945"
            };

            IList<int> res = Valid(deviceNums);
            if (res.Count != 0)
            {
                Console.WriteLine(res.Count);
                foreach (int i in res)
                {
                    Console.Write(i + " ");
                }
            }


        }

        public static IList<int> Valid(List<string> vs)
        {
            List<string> copy = new List<string>(vs);
            List<int> order = new List<int>() { 1 };

            string current = vs[0];
            vs.Remove(current);

            bool hasMatch = false;

            while (true)
            {
                hasMatch = false;

                for (int i = vs.Count - 1; i >= 0; i--)
                {
                    if (IsMatch(current, vs[i]))
                    {
                        if (i == vs.Count - 1)
                        {
                            order.Add(copy.Count);
                            return order;
                        }
                        else
                        {
                            current = vs[i];
                            order.Add(copy.FindIndex(p => p == current) + 1);
                            vs.Remove(current);
                            hasMatch = true;
                            break;
                        }
                    }
                }

                if (!hasMatch)
                    return new List<int>();
            }

        }


        public static bool IsMatch(string s1, string s2)
        {
            char num = 'n';
            for (int i = 0; i < 10; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (num == 'n')
                    {
                        num = s1[i];
                    }
                    else if (num != s2[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
