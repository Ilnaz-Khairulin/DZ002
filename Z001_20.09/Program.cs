internal class Program
{
    private static void Main(string[] args)
    {
        int n = 456;
        int[] aray = new int[3];
        if (n>=0)
        {
            aray[0] = n % 10;
            Console.WriteLine(aray[0]);
            n = n / 10;
            Console.WriteLine(n);
            aray[0]++;
        }
         else
        {
      Console.WriteLine(aray[1]);  
    }
    
    }
}