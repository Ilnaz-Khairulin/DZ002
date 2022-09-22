int n = 645;
if(n<=99)
{
    System.Console.WriteLine("нет третей цифры. ");
}
else{
while(n>=1000)
{
n = n/10;

}
n = n%10;
System.Console.WriteLine(n);
}