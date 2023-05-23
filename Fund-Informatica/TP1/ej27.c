#include <stdio.h>
#include <stdlib.h>

int main(){      

    float cpm;
      
    printf("Ingrese el importe de la compra: ");
    scanf("%f",&cpm);

    printf("El valor del producto es: %.2f \n",cpm);
    printf("El 10%% valor del producto es: %.2f \n",cpm*0.1);
    printf("El valor del producto + el 10%% es: %.2f \n",cpm*1.1);

    return 0;
    
}
