#include <stdio.h>
#include <stdlib.h>

int main(){      

    float prod;
      
    printf("Ingrese el valor de un producto: ");
    scanf("%f",&prod);

    printf("El valor del producto + IVA es: %.2f \n",prod*1.21);

    return 0;
    
}
