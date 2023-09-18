using System.Collections.Generic;

namespace Subarray_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 2;
            int d = 3;
            List<int> s = new List<int>()
            {
                1,2,1,3,2,3,0
            };
            int count = 0;

            for (int i = 0; i < s.Count; i++)
            {
                int tmp = 0;

                for (int j = i; j < i + m; j++)
                {
                    if (j == s.Count) break;
                    tmp += s[j];
                }

                if (d == tmp) count++;
            }
            Console.WriteLine(count);
        }
    }
}