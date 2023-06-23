#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

int main(){

    int numeros[10];
    int i,num1,num2,esta1 = 0,esta2 = 0;

    for (i = 0; i < 10; i++){
        printf("Ingrese un numero: ");
        scanf("%d", &numeros[i]);
    }

    printf("\nIngrese un numero para buscarlo en el vector: ");
    scanf("%d", &num1);
    printf("Ingrese otro numero para buscarlo en el vector: ");
    scanf("%d", &num2);

    for (i = 0; i < 10; i++){
        if (num1 == numeros[i]){
            esta1 = 1;
        }
        if (num2 == numeros[i]){
            esta2 = 1;
        }
    }

    if (esta1 == 1 && esta2 == 1){
        printf("\nLos numeros %d y %d estan entre los anteriores", num1, num2);
    }
    else if (esta1 == 1 && esta2 == 0){
        printf("\nEl numero %d esta entre los anteriores", num1);
    }
    else if (esta1 == 0 && esta2 == 1){
        printf("\nEl numero %d esta entre los anteriores", num2);
    }
    else{
        printf("\nLos numeros %d y %d no estan entre los anteriores", num1, num2);
    }

}

