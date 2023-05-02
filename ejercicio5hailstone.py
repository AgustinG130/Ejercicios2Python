import math
n = int(input("Ingrese numero "))
if n % 2 == 0:
	n=n/2
	print("Su numero es par y es ", n)
else:
	n = n * 3 + 1
	print("su numero es impar y es ", n)
if n == 7:
	print("7 -> 22 -> 11 -> 34 -> 17 -> 52 -> 26 -> 13 -> 40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1")