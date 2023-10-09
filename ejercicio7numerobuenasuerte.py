digitos = 0
n = int(input("Escriba su numero de 4 digitos maximo "))

if n > 0:
        for i in range (1,n):
            digitos += 1
        medio1 = ((n - (n % 10)) / 10)
        medio2 = medio1 % 100
        if n == 21:
         print("Es de buena suerte ", n)
        elif digitos > 3:
         if (n % 100) == 21:
            print("Es de buena suerte ", n)
         elif round(n / 10) == 21:
            print("Es de buena suerte ", n)
         elif round(n / 100) == 21:
            print("Es de buena suerte: ", n)
         elif round(medio2) == 21:
            print("Es de buena suerte: ", n)
         else:
            print("Su numero no es de buena suerte ", n)
else:
    print("Su numero no es de buena suerte ", n)