


internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] n = {9,8,7,6,5,4,3};

        int g = 0;

        while(n[0] <= n.Length)
        {
            g = g + n[0];
            System.Console.WriteLine(g);
            n[0]++;
        }
        
        Console.WriteLine(g);
        g = g/7;

        Console.WriteLine(g);
    }
}