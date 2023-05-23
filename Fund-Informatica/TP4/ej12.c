#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

int main(){

    char string[50];
    char string2[50];

    printf("Ingrese un string: ");
    fflush(stdin);
    gets(string);

    for (int i = 0; i < strlen(string); i++){
        if (towlower(string[i]) == 'a' || towlower(string[i]) == 'e' || towlower(string[i]) == 'i' || towlower(string[i]) == 'o' || towlower(string[i]) == 'u'){
            string2[i] = '.';
        }
        else{
            string2[i] = string[i];
        }
    }

    printf("El string: %s ,reemplazando las vocales por puntos es: %s",string,string2);

    return 0;
}