suma = 0
n = int(input("Ingrese Numero, 0 para cerrar programa "))
while n != 0:
    if n > 0:
        suma = suma+n
    n = int(input("Ingrese Numero, 0 para cerrar programa "))
print("Su sumatoria es:", suma)