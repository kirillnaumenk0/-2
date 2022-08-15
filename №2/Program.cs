Console.WriteLine("Введите число");
string num = Console.ReadLine();
if(num.Length < 3)
{
Console.WriteLine("Третья цифра отсутствует");
}
else
{
if(Convert.ToInt32(num) < 0)
{
Console.WriteLine("Третья цифра: " + num[3]);
} 
else
{
Console.WriteLine("Третья цифра: " + num[2]);
}
}
