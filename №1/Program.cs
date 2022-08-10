Console.WriteLine("Введите тёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if(a > 100)
{
    if(a < 900)
    {
     int b = a % 100;
     b/= 10;
     Console.WriteLine(b);
    }
    else
    {
    Console.WriteLine("Вы ввели неверное число");
    }
}
else
{
Console.WriteLine("Вы ввели неверное число");
}