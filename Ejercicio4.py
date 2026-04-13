import math

radio = float(input('Radio del círculo: '))

# Área = π * r * r
area = math.pi * radio * radio

# Perímetro = 2 * π * r
perimetro = 2 * math.pi * radio

# Salida
print(f'Area: {area:.4f}')
print(f'Perimetro: {perimetro:.4f}')