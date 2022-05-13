Console.WriteLine("введите координату Х");
Console.WriteLine("введите координату Y");
int x = int.Parse(Console.ReadLine() ?? "0");
int y = int.Parse(Console.ReadLine() ?? "0");
if (x==0 || y==0)
Console.WriteLine ("Х и У не равны нулю, введите другие координаты!");
if (x>0 && y>0)
Console.WriteLine ("I четверть!");
if (x<0 && y>0)
Console.WriteLine ("II четверть!");
if (x<0 && y<0)
Console.WriteLine ("III четверть!");
if (x>0 && y<0)
Console.WriteLine ("IV четверть!");
