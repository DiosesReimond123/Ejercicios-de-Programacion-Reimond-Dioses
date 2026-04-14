Console.Write("Consumo en kWh: ");
double kwh = double.Parse(Console.ReadLine());

double subtotal = 5 + (kwh * 0.55);
double igv = subtotal * 0.18;
double total = subtotal + igv;

Console.WriteLine($"Subtotal: S/. {subtotal:F2}");
Console.WriteLine($"IGV (18%): S/. {igv:F2}");
Console.WriteLine($"Total: S/. {total:F2}"); Console.WriteLine(
