#include <stdio.h>
#include <stdlib.h>

int main(){

    float peso;
    int edad;
    char nombre[15];
        
    printf("Ingrese su Nombre: ");
    scanf("%s",&nombre);

    printf("Ingrese su Edad: ");
    scanf("%d",&edad);

    printf("Ingrese su peso en kg: ");
    scanf("%f",&peso);


    printf("Hola %s, tenes %d anios y pesas %.2f kg",nombre,edad,peso);

    return 0;
    
}
