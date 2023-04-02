
System.Console.Write("Первая точка X: ");
int numX1 = int.Parse(Console.ReadLine());

System.Console.Write("первая точка Y: ");
int numY1 = int.Parse(Console.ReadLine());

System.Console.Write("первая точка Z: ");
int numZ1 = int.Parse(Console.ReadLine());

System.Console.Write("вторая точка X: ");
int numX2 = int.Parse(Console.ReadLine());


System.Console.Write("вторая точка Y: ");
int numY2 = int.Parse(Console.ReadLine());



System.Console.Write("вторая точка Z: ");
int numZ2 = int.Parse(Console.ReadLine());

Double skalyar = Math.Sqrt(Math.Pow((numX2-numX1),2) + Math.Pow((numY2-numY1), 2) + Math.Pow((numZ1-numZ2),2));

System.Console.Write(skalyar);