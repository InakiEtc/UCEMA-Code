#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>

int main(){

    int tam,*vocales;
    char *cadena;
    
    vocales = (int*) malloc(sizeof(int));
    *vocales = 0;

    printf("Ingrese el tamano de la cadena: ");
    scanf("%d",&tam);

    cadena = (char *)malloc(tam*sizeof(char));

    printf("Ingrese la cadena: ");
    scanf("%s",cadena);

    for(int i=0; i<tam; i++){
        if(cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u'){
            (*vocales)++;
        }
    }

    printf("La cantidad de vocales es: %d\n",*vocales);

    free(cadena);    

    return 0;
}