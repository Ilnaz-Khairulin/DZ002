


internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] n = {1,57,3,89,75,6,7};

        int count = 0;
System.Console.WriteLine(n[4]);
        while (n[0] <= n.Length)
        {

            count =count+ n[0];
            System.Console.WriteLine(count);
            n[0]++;
        }
        
    Console.WriteLine(count);
        count = count/7;

        Console.WriteLine(count);
    }
}