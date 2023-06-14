namespace Review1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int flag = 1;
            int[] array = { 1, 2, 4, 7, 9, 10, 24, 31 };
            for(int i = array.Length-1; i >=0; i--)
            {
                    if (array[i] % 2 != 0 && flag <= 2)
                    {
                        //Console.WriteLine(array[i]);
                        flag++;
                    }
                Console.WriteLine(i);
            }
        }
    }
}