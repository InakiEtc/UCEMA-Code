#include <stdio.h>
#include <stdlib.h>

int main(){

    float num,i,suma;
    suma=0;
    i=0;

    while (num!=0){
        printf("Ingrese un numero: ");
        scanf("%f",&num);

        if (num!=0){
            suma=suma+num;
            i++;
        }
    }
    printf("El promedio de los numeros ingresados es %.2f",suma/i);


    return 0;
}