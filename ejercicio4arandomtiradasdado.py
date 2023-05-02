import random
#a) Programa de las 20 tiradas del 1 al 6
for i in range(20):
    d1 = random.randint(1,6)
    d2 = random.randint(1,6)
    prom = round((d1+d2)/2)
    print(prom)