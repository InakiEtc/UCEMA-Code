#include <stdio.h>
#include <stdlib.h>

int main(){

    float cmp;
    printf("Ingrese el monto de la compra: ");
    scanf("%f",&cmp);
    
    if (cmp<500){
        printf("El monto a pagar es de $%.2f",cmp);
    }
    else if(cmp>=500 && cmp<=1000){
        printf("El monto a pagar es de $ %.2f \n",cmp);
        printf("El descuento es de 5%% \n");
        printf("El monto a pagar con descuento es de $%.2f \n",cmp-(cmp*0.05));  
    }
    else if(cmp>1000 && cmp<=7000){
        printf("El monto a pagar es de $ %.2f \n",cmp);
        printf("El descuento es de 11%% \n");
        printf("El monto a pagar con descuento es de $%.2f \n",cmp-(cmp*0.11));  
    }
    else if(cmp>7000 && cmp<=15000){
        printf("El monto a pagar es de $ %.2f \n",cmp);
        printf("El descuento es de 18%% \n");
        printf("El monto a pagar con descuento es de $%.2f \n",cmp-(cmp*0.18));  
    }
    else{
        printf("El monto a pagar es de $ %.2f \n",cmp);
        printf("El descuento es de 25%% \n");
        printf("El monto a pagar con descuento es de $%.2f \n",cmp-(cmp*0.25));  
    }
    
    
    return 0;
}