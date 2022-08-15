string[] Week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье", };
Console.WriteLine("Введите день недели");
for (int i = 0; i < Week.Length; i++)
{
    Console.WriteLine(i + 1 + " - " + Week[i] + ", ");
}
Console.WriteLine(" ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("да" + day + " - выходной!");
}
else
{
    Console.WriteLine("нет" + day + " - будни:(");
}