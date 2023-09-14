namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> dizi = new List<int>()
            {
                3,1,9,7,5
            };
            int sum = 0;
            dizi.Sort();
            int min = dizi[0];
            int max = dizi[dizi.Count-1];
            for (int i = 0; i < dizi.Count; i++)
            {
                sum+= dizi[i];
            }
            Console.WriteLine((sum - max) + " " + (sum - min));

        }
    }
}