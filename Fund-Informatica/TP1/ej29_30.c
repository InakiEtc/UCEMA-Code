#include <stdio.h>
#include <stdlib.h>

int main(){      

    float imp,interes;
    int meses;
      
    printf("Ingrese el importe a considerar: ");
    scanf("%f",&imp);
    //printf("Ingrese el porcentaje del interes mensual: "); //ej29
    //scanf("%f",&interes); //ej29
    printf("Ingrese el plazo en meses: ");
    scanf("%d",&meses);

    // printf("El importe final en %d mes/es sera de $%.2f con un interes de %.2f%% mensual \n",meses,imp + (meses*(imp*(interes/100))),interes); //ej29
    printf("El importe final en %d mes/es sera de $%.2f con un interes de 2.5%% mensual \n",meses,imp + (meses*(imp*0.025))); //ej30

    return 0;
    
}
