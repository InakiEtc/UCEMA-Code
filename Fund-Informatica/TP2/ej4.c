#include <stdio.h>
#include <stdlib.h>

int main(){

    
    char letra;
    printf("Ingrese una letra: ");
    scanf("%c",&letra);

    if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u'){
        printf("La letra ingresada es Vocal");
    }
    else if(letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U'){
        printf("La letra ingresada es Vocal");
    }
    else{
        printf("La letra ingresada es Consonante");
    }

    return 0;

}