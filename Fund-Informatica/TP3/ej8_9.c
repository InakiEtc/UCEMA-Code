#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){

    float suma; // ej 9
    suma=0; // ej 9

    srand(time(NULL));
    for (int i = 0; i < 50; i++){
        printf("%d \n",rand() % 100);
        suma=suma+rand() % 100; // ej 9
    }

    printf("El promedio de los numeros aleatorios es: %.2f",suma/50); // ej 9

    return 0;
}