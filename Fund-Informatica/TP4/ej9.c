#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

int main(){

    char palabra[5];

    printf("Ingrese una palabra de 5 caracteres: ");
    fflush(stdin);
    gets(palabra);

    if (tolower(palabra[0]) == tolower(palabra[4]) && tolower(palabra[1]) == tolower(palabra[3])){
        printf("La palabra es capicua");
    }
    else{
        printf("La palabra no es capicua");
    }
    
    return 0;
}
