#include <stdio.h>
#include <stdlib.h>

int main(){

    float a, b, suma;
    float *pa = &a;
    float *pb = &b;
    float *psuma = &suma;

    printf("Ingrese el primer valor : ");
    scanf("%f", pa);
    printf("Ingrese el segundo valor : ");
    scanf("%f", pb);

    *psuma = *pa + *pb;

    printf("La suma de los valores es : %.2f\n", *psuma);

    return 0;
}