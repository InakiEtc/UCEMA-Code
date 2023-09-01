#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(){

    char *cadena;
    char entrada[50];

    printf("Ingrese una cadena de texto: ");
    gets(entrada);

    cadena = (char *)malloc(strlen(entrada));
    if (cadena == NULL) {
        printf("Error: No se pudo reservar memoria.\n");
        return 1;
    }
    cadena=entrada;

    printf("La cadena almacenada es: %s\n", cadena);

    free(cadena);

    return 0;
}
