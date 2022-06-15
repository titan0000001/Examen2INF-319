# -*- coding: utf-8 -*-
"""
Created on Sat Jun 11 18:40:11 2022

@author: YURIKA MACUSAYA AGUILAR 
"""
#PREGUNTA 1, PYTHON
# Python program to display the Fibonacci sequene from 1st fibonaccio to N fibonacci
# 3 terms until  N = 7 
def estructurado_fibo(a=-1, b=1, f=0, n=0):        
    while n!=0:
        a, b = b, a + b
        print(b, end=',')
        n = n-1
        
def recur_fibo(a, b, f, n):
    if n != 0:    
        f = a + b
        a = b
        b = f        
        print(f, end=',')
        recur_fibo(a, b, f, n-1)

#PREGUNTA 2, PYTHON
#funciones de order superior
def funciones(funcion,d =0):
    return funcion(-1, 1, 0, d)

print('funciones de orden superior')
print('estructurado')
funciones(estructurado_fibo, 7)
print('\nrecursivo' )
funciones(recur_fibo, 7)

#PREGUNTA 3, PYTHON
#lambda
print('\nusando lambda' )
from functools import reduce
fib = lambda n: reduce(lambda x, _: x+[x[-1]+x[-2]], range(n-2), [0, 1])   
print(fib(7)) 
#enterprise java beans
