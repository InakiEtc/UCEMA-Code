#include <stdio.h>
#include <stdlib.h>

void promedio(float *a, float *b, float *c, float *prom);

int main(){

    float a, b, c, prom;
    printf("Ingrese el valor de A: ");
    scanf("%f", &a);
    printf("Ingrese el valor de B: ");
    scanf("%f", &b);
    printf("Ingrese el valor de C: ");
    scanf("%f", &c);

    printf("El promedio es: %.2f\n", (a + b + c) / 3);

    promedio(&a, &b, &c, &prom);
    printf("El promedio es: %.2f", prom);

    return 0;
}

void promedio(float *a, float *b, float *c, float *prom){
    *prom = (*a + *b + *c) / 3;
}
