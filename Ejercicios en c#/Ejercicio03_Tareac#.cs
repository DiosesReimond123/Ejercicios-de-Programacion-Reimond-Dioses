Console.Write("Temperatura en Celsius: ");
double c = double.Parse(Console.ReadLine());

// Conversión
double f = c * (9.0 / 5) + 32;
double k = c + 273.15;

// Salida
Console.WriteLine($"Fahrenheit: {f:F2}");
Console.WriteLine($"Kelvin: {k:F2}"); Console.WriteLine();