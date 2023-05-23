#include <stdio.h>
#include <stdlib.h>

int main(){

    int yerba,azucar,bebida;
    float pan,res;

    printf("Cuantos paquetes de yerba va a comprar? ");
    scanf("%d",&yerba);
    printf("Cuantos paquetes de azucar va a comprar? ");
    scanf("%d",&azucar);
    printf("Cuantos kg de pan va a comprar? ");
    scanf("%f",&pan);
    printf("Cuantos gaseosas va a comprar? ");
    scanf("%d",&bebida);

    res = (65*yerba)+(25*azucar)+(28*pan)+(24*bebida);
    printf("El total seria %.2f$ \n",res); // ej37
    printf("Pagando de contado con el 10%% seria %.2f$ \n",res-(res*0.1)); // ej38


    return 0;

}