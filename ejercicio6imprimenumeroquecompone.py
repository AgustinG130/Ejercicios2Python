def ultimodigito(n):
    ultimod = 0
    digitos = 0
    if n >= 0:
        for i in range (1,n):
            digitos += 1
        if digitos <= 1:
         ultimod = n
         print("Su ultimo digito es ", ultimod)
        if digitos > 2:
         ultimod = n % 10
         print("Su ultimo digito es ", ultimod)
    else:
        print("su numero es menor que 0 ")

def sacarultimodigito(n):
    ultimod = 0
    digitos = 0
    resultado = 0
    if n >= 0:
        for i in range (1,n):
            digitos += 1
        if digitos <= 1:
         resultado = 0
         print("Su numero sin ultimo digito es ", resultado)
        if digitos > 2:
         ultimod = n % 10
         resultado = n - ultimod
         print("Su numero sin ultimo digito es ", round(resultado/10))
    else:   
        print("su numero es menor que 0 ")
    
n = int(input("Escriba su numero para saber cual es su ultimo digito "))
print(n)
ultimodigito(n)
sacarultimodigito(n)