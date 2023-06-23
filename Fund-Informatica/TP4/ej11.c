#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

int main(){

    char palabra[50];
    int vocales = 0,conson = 0;

    printf("Ingrese una palabra: ");
    fflush(stdin);
    gets(palabra);

    for (int i = 0; i < strlen(palabra); i++){
        if (towlower(palabra[i]) == 'a' || towlower(palabra[i]) == 'e' || towlower(palabra[i]) == 'i' || towlower(palabra[i]) == 'o' || towlower(palabra[i]) == 'u'){
            vocales++;
        }
        else{
            conson++;
        }
    }

    printf("La palabra %s tiene %d vocales y %d consonantes",palabra,vocales,conson);

   return 0; 
}
