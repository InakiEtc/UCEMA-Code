#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(){

    char palabra[30];
    int cont=0;

    printf("Ingrese un palabra, la palabra fin corta el prg: ");
    scanf(" %s",&palabra);

    while(strcmp(strlwr(palabra), "fin") != 0){
        cont++;

        printf("Ingrese un palabra, la palabra fin corta el prg: ");
        scanf(" %s",&palabra);
    }
    
    printf("Ingreso %d palabras",cont);
    return 0;
}