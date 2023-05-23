#include <stdio.h>
#include <stdlib.h>

int main(){

    float km,valf;
    valf=10000;
    printf("Ingrese la cantidad de Km recorridos: ");
    scanf("%f",&km);
    
    if (km<=400){
        printf("El valor de la tarifa es $%.1f",valf);
    }
    else if (km>400){
        if(km<2000){
            km=km-400;
            // si los 30 km estan 100$, 1 km esta 3.33$
            printf("El valor de la tarifa es $%.2f",valf+(km*3.33));
        }
        else{
            km=km-400;
            printf("El valor de la tarifa es $%.2f con un impuesto del $250",valf+250+(km*3.33));
        }
        
    }

    return 0;
}