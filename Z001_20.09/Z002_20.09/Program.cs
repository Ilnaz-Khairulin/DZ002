Console.WriteLine("Введите цифру от 1 до 7 : ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(n);
if(n>0 && n<6)
{
    Console.WriteLine("не выходной!!!");
}
else if(n>5 && n<8)
{
    Console.WriteLine("выходной!!!");
}
else
{
    Console.WriteLine("ошибка ввода!");
}