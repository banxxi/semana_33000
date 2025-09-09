def ejer1():
    nombre=input("ingrese su nombre:")
    carrera= input ("ingrese su carrera:")

    print(f"\n{nombre}, bienvenido al curso de fundamentos algoritmo de la carerera{carrera}") 

def ejer2():
    print("\"Hellen\"")

def ejer3():
    num1 = int (input("ingrese numero 1 : "))
    num2 = int (input("ingrese numero 2 : "))

    print ("suma: ", (num1 +num2))
    print ("resta: ", (num1 -num2))
    print ("multiplicacion: ", (num1 *num2))
    print ("divicion: ", (num1 /num2))

import math
from re import Match # importando libreria math

def ejer4():
    num = float ( input("ingrese numero decimal"))
    
    raiz = math.sqrt(num)
    redo=round(num,2)
    cubo=math.pow (num,3)
    cubica=num  ** (1/3)

    print("raiz cuadrada: ", raiz)
    print("redondeado: ", redo)
    print("al cubo: " , cubo)
    print("raiz cubica:", cubica)

ejer4()


