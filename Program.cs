using System ;

Point p1 = new Point();
p1.X = 7;

Point p2 = p1;

Console.WriteLine (p1.X);
Console.WriteLine (p2.X);

p1.X = 9;

Console.WriteLine (p1.X);
Console.WriteLine (p2.X);

public class Point { public int X; public int Y; }
