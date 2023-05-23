#include <stdio.h>
#include <stdlib.h>
#include <math.h>


int main(){

    float num;
    printf("Ingrese el termino cuadratico: ");
    scanf("%f",&num);

    printf("Las raiz cuadrada de %.2f es = %.2f",num,sqrtf(num));

    return 0;

}
