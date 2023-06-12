#include <stdio.h>
#include <stdlib.h>

float promedio(int array[]);
int aleatorio();

int main(){

    int arr[3];
    arr[3] = aleatorio();

    printf("El primer numero es: %d", arr[0]);
    printf("\nEl segundo numero es: %d", arr[1]);
    printf("\nEl tercer numero es: %d", arr[2]);

    printf("\nEl promedio es: %.2f", promedio(arr));
    return 0;
}


int aleatorio(){
    int array[3];
    for(int i = 0; i < 3; i++){
        array[i] = rand() % 101;
    }
    return array;
}

float promedio(int array[]){
    return (array[0] + array[1] + array[2]) / 3;
}