import math

monto = float(input('Monto en soles: '))

# Redondea hacia arriba
hacia_arriba = math.ceil(monto)

# Redondea hacia abajo
hacia_abajo = math.floor(monto)

# Truncado (elimina decimales)
truncado = int(monto)

# Redondeo a 2 decimales
redondeado = round(monto, 2)

# Salida
print(f'Monto original: {monto}')
print(f'Ceiling (hacia arriba): {hacia_arriba}')
print(f'Floor (hacia abajo): {hacia_abajo}')
print(f'Truncado (int): {truncado}')
print(f'Redondeado (2 decimales): {redondeado}')