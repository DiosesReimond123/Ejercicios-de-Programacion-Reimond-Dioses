Console.Write("Número de habitaciones: ");
int habitaciones = int.Parse(Console.ReadLine());

Console.Write("Número de baños: ");
int baños = int.Parse(Console.ReadLine());

Console.Write("Número de patios: ");
int patios = int.Parse(Console.ReadLine());

double total = (habitaciones * 30) + (baños * 10) + (patios * 15);

Console.WriteLine($"Total mensual: S/. {total:F2}");
