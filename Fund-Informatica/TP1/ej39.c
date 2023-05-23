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

    printf("\nYerba = 65$ \n");
    printf("IVA: 21%% \n");
    printf("Cantidad: %d \n",yerba);
    printf("Subtotal: %.2f \n",(65*yerba*1.21));

    printf("\nAzucar = 25$ \n");
    printf("IVA: 21%% \n");
    printf("Cantidad: %d \n",azucar);
    printf("Subtotal: %.2f \n",(25*azucar*1.21));

    printf("\nKg de Pan = 28$ \n");
    printf("IVA: 21%% \n");
    printf("Cantidad: %f \n",pan);
    printf("Subtotal: %.2f \n",(28*pan*1.21));

    printf("\nGaseosa = 24$ \n");
    printf("IVA: 21%% \n");
    printf("Cantidad: %d \n",bebida);
    printf("Subtotal: %.2f \n",(24*bebida*1.21));

    printf("----------------------- \n");

    res = (65*yerba*1.21)+(25*azucar*1.21)+(28*pan*1.21)+(24*bebida*1.21);

    printf("TOTAL A PAGAR = %.2f$ \n",res);
    printf("TOTAL A PAGAR DE CONTADO = %.2f$ \n",res-(res*0.1));


    return 0;
}