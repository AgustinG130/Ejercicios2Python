mayor = 0
n = int(input("Ingrese numero positivo "))

while n != 0:
    if n > 0:
       if n > mayor:
            mayor = n
    n = int(input("Ingrese numero positivo "))

print("El numero mas grade fue: ", mayor)