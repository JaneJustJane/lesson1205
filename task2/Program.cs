Console.WriteLine("введите пятизначное число ");
int a = int.Parse(Console.ReadLine() ?? "0");
if (a>99999)
Console.WriteLine("это число не пятизначное!");
else if (a/10000 == a%10 && a/1000%10 == a/10%10)
{
    Console.WriteLine("это число палиндром");
}
else
{
    Console.WriteLine("это число не палиндром");
}