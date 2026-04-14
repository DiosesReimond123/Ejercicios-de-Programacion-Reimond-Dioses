Console.Write("Radio del circulo: ");
double radio = double.Parse(Console.ReadLine());

// Área = π * r * r
double area = Math.PI * radio * radio;

// Perímetro = 2 * π * r
double perimetro = 2 * Math.PI * radio;

Console.WriteLine($"Área: {area:F4}");
Console.WriteLine($"Perimetro: {perimetro:F4}");