#include <stdio.h>
#include <stdlib.h>

int main(){

    int num, aux;
    // int arr[4]; // ej2
    int arr[6]; // ej3

    printf("Ingrese un numero de 6 cifras: ");
    scanf("%d", &num);
    
    aux = num;

    for(int i=0; aux>0; i++){
        arr[i] = aux%10;
        aux /= 10;
    }

    // if(arr[0] == arr[3] && arr[1] == arr[2]){ // ej2
    if(arr[0] == arr[5] && arr[1] == arr[4] && arr[2] == arr[3]){ //ej3
        printf("El numero %d es capicua\n", num);
    }
    else{
        printf("El numero %d no es capicua\n", num);
    }   

    return 0;
}