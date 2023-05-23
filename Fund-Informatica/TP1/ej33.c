#include <stdio.h>
#include <stdlib.h>

int main(){      

    float km,min;
      
    printf("Ingrese la distancia en km: ");
    scanf("%f",&km);
    printf("Ingrese el tiempo en minutos: ");
    scanf("%f",&min);

    printf("La velocidad del proyectil es de: %.2f m/s \n",16.67*(km/min));

    return 0;
    
}
