namespace EvTapshirigi6
{
    internal class Program
    {
        static void Main(string[] args)
        {   //7-e bolende qaligi 1,2 veya 5 olan elementlerin sayi
            
            Console.Write("Massivin uzunlugunu daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 7 == 1 || arr[i] % 7 == 2 || arr[i] % 7 == 5) 
                Console.WriteLine(arr[i]);
            }
        }
    }
}
