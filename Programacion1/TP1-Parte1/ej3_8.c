#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(){

    char entrada[30], *cadena = NULL, *cadenaRedim = NULL;
    int tam = 0,tam2 = 0;

    printf("Ingrese una cadena de texto: ");
    fflush(stdin);
    gets(entrada);

    tam = strlen(entrada);
    cadena = (char *)malloc(tam);

    if (cadena != NULL){
        strcat(entrada, " ");
        strcpy(cadena, entrada);
        printf("\nLa cadena 1 dinamica es: %s", cadena);
    }else{
        printf("\nNo se pudo reservar memoria");
    }

    printf("\nIngrese otra cadena de texto: ");
    fflush(stdin);
    gets(entrada);

    tam2 = strlen(entrada);
    cadenaRedim = (char *)realloc(cadena, tam2+tam);

    if (cadenaRedim != NULL){
        strcat(cadenaRedim, entrada);
        printf("\nAmbas cadenas dinamicas son: %s", cadenaRedim);
    }else{
        printf("\nNo se pudo reservar memoria");
    }

    free(cadena);
    free(cadenaRedim);

    return 0;
}