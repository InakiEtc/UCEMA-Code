#include <stdio.h>
#include <stdlib.h>

int main(){

    int valor,incremento,decremento;
    printf("Ingrese un numero entero: ");
    scanf("%d",&valor);

    //incremento=valor+1; //ejercicio 4, incremento 1
    //decremento=valor-1; //ejercicio 4, decremento 1

    incremento=valor+5; //ejercicio 5, incremento 5
    decremento=valor-3; //ejercicio 5, decremento 3

    printf("Valor: %d \n",valor);
    printf("Incremento: %d \n",incremento);
    printf("Decremento: %d \n",decremento);

    return 0;
}