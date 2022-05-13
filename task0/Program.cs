Console.WriteLine("введите число ");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = a%7;
int c = a%23;
if (b==0)
{
Console.Write("это число кратно 7!");
}
else
{
Console.Write("это число некратно 7!");
}
if (c==0)
{
Console.Write("это число кратно 23!");
}
else
{
Console.Write("это число некратно 23!");
}