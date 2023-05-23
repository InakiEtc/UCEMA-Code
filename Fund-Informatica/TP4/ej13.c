#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

int main(){
    char palabra[50];

    printf("Ingrese una palabra: ");
    fflush(stdin);
    gets(palabra);

    for (int i = 0; i < strlen(palabra); i++){
        if (islower(palabra[i])){
            palabra[i] = toupper(palabra[i]);
        }
        else{
            palabra[i] = tolower(palabra[i]);
        }
    }

    printf("La palabra ingresada es: %s",palabra);

    return 0;
}