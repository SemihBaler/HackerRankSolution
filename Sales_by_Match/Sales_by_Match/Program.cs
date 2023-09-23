namespace Sales_by_Match
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ar = new List<int>()
            {
                10,20,20,10,10,30,50,10,20,10
            };
            int n=ar.Count;
            int count = 0;
            int max = ar.Max() + 1;
            for (int i = 0; i < n - 1; i++)
            {
                if (ar[i] == max)
                {
                    continue;
                }
                for (int x = i + 1; x < n; x++)
                {
                    if (ar[i] == ar[x])
                    {
                        ar[i] = max;
                        ar[x] = max;
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine(count);





        }
    }
}