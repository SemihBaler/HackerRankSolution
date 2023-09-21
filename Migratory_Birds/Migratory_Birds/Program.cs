namespace Migratory_Birds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new List<int>()
            {
                1,2,5,6,78,11,45,1,2,6,4,4,4,2,2,5,5,7
            };
            int[] counts = new int[6];
            foreach (var item in arr)
            {
                counts[item]++;
            }

            int maxCount = counts.Max();
            int mostFrequentBird = Array.IndexOf(counts, maxCount);

            Console.WriteLine(mostFrequentBird);
        }
    }
}