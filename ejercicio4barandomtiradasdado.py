import random

#b) Programa que cuenta la cantidad de veces que se repite una cara en las 20 tiradas
#Por alguna razón solo funciona si lo ejecuto como debug pero funciona perfectamente
aux1 = 0
aux2 = 0
aux3 = 0
aux4 = 0
aux5 = 0
aux6 = 0
for i in range(20):
    d1 = random.randint(1,6)
    prom = round(d1)
    match d1:
        case 1:
            aux1 = aux1 +1
        case 2:
            aux2 = aux2 +1
        case 3:
            aux3 = aux3 +1
        case 4:
            aux4 = aux4 +1
        case 5:
            aux5 = aux5 +1
        case 6:
            aux6 = aux6 +1

    print("Su promedio fue de ", prom)
    print(" y la cara 1 salió: ", aux1)
    print(" y la cara 2 salió: ", aux2)
    print(" y la cara 3 salió: ", aux3)
    print(" y la cara 4 salió: ", aux4)
    print(" y la cara 5 salió: ", aux5)
    print(" y la cara 6 salió: ", aux6)
