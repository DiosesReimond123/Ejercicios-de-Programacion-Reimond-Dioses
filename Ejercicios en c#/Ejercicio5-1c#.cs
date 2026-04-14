Console.Write("Monto en soles: ");
double monto = double.Parse(Console.ReadLine());

// Math.Ceiling(x) → redondea hacia arriba
double haciaArriba = Math.Ceiling(monto);

// Math.Floor(x) → redondea hacia abajo
double haciaAbajo = Math.Floor(monto);

// (int)x → elimina decimales
int truncado = (int)monto;

// Math.Round(x, n) → redondeo normal a n decimales
double redondeado = Math.Round(monto, 2);

// Salida
Console.WriteLine($"Monto original: {monto}");
Console.WriteLine($"Ceiling (hacia arriba): {haciaArriba}");
Console.WriteLine($"Floor (hacia abajo): {haciaAbajo}");
Console.WriteLine($"Truncado (casting int): {truncado}");
Console.WriteLine($"Redondeado (2 decimales): {redondeado}");
