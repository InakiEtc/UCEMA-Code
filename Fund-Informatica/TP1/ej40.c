#include <stdio.h>
#include <stdlib.h>

int main(){

    
    int min;

    printf("Ingrese la duracion de la llamada (en minutos): ");
    scanf("%d",&min);

    printf("El valor de la llamada seria: %.2f$ ",(min*60)*0.054);

    return 0;

}