// Pedimos las 4 coordenadas: dos puntos en el plano cartesiano.
// Usamos double porque las coordenadas pueden tener decimales.
Console.Write("x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("y2: ");
double y2 = double.Parse(Console.ReadLine());

// Paso 1: calcular las diferencias en cada eje (los "catetos"
// del triángulo rectángulo que forman los dos puntos).
double dx = x2 - x1;  // diferencia horizontal
double dy = y2 - y1 ;  // difcrencia vertical

// Paso 2: aplicar Pitágoras > d = (dx' + dy*)
// Math. Sqrt(x) calcula la raiz cuadrada de x.
double distancia = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

// Formato :F2 + muestra el resultado con 2 decimales.
Console.WriteLine($"Distancia entre los puntos: {distancia:F2}");