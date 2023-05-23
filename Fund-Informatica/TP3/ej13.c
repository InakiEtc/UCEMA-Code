#include <stdio.h>
#include <stdlib.h>

int main(){

    char palabra[30];

    printf("Ingrese un palabra, de hasta 30 caracteres: ");
    scanf("%s",&palabra);

    for (int i = 0; i < 1000; i++){
        printf("%s ",palabra);
    }
    
    return 0;
}