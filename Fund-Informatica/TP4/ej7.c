#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){

    srand(time(NULL));

    float suma=0;
    int arr1[20], arr2[20], arr3[20];

    for (int i=0; i<20; i++){
        arr1[i] = rand() % 101 + 1;
        arr2[i] = rand() % 101 + 1;
        arr3[i] = arr1[i] + arr2[i];

        printf("%d + %d = %d \n", arr1[i], arr2[i], arr3[i]);
        suma += arr3[i];
    }

    printf("\nEl promedio de la suma de los elementos de los vectores es: %.2f\n", suma/20);

    return 0;
}