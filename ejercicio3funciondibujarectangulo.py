
ancho = int(input("Ingrese ancho "))
altura = int(input("Ingrese su altura "))

def rectangulo(al,an):
    print("x" * ancho)

    for i in range(1,(altura-1)):
       print("x" + " "*(ancho-2) + "x")
    
    print("x" * ancho)

rectangulo(altura,ancho)

