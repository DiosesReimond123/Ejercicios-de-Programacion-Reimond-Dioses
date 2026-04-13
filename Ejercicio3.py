#t Importamos el módulo math, que contiene funciones matemáticas
import math

# Pedimos las 4 coordenadas.
x1 = float(input('x1: '))
y1 = float(input('y1: '))
x2 = float(input('x2: '))
y2 = float(input('y2: '))

dx = x2 - x1 # diferencia horizontal
dy = y2 - y1 # diferencia vertical

# math.sqrt(x) calcula la raíz cuadrada, equivalente a Math.Sqrt de C#.
distancia = math.sqrt(dx*dx + dy*dy)

print(f'Distancia enlre los punlos: {distancia:.2f}')