Console.Write("Введите первую координату точки один - ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату точки один - ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью координату точки один - ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую координату точки два - ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату точки два - ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью координату точки два - ");
int z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) *
                                   1.0), 0.5);
Console.WriteLine($"Расстояние между точками = {d}");