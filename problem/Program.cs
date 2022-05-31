using System;
using System.Linq;

namespace problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            int[] t = new int[10];
            t = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] n = new int[a];
            for(int i = 0; i < a; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
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
