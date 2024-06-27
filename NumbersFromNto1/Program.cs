class NumbersFromNto1
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = N; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
}