#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

int main(){

    char string[50], strMayus[50];
    int j = 0;

    printf("Ingrese una cadena de caracteres: ");
    fflush(stdin);
    gets(string);

    for(int i = 0; i < strlen(string); i++){
        if(isupper(string[i])){
            strMayus[j] = string[i];
            j++;
        }
    }

    if(j == 0){
        printf("La cadena ingresada no posee letras en mayusculas.");
    }
    else{
        printf("La cadena formada unicamente por las letras en mayusculas de la cadena ingresada es: ");
        puts(strMayus);
    }

    return 0;
}