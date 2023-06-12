#include <stdio.h>
#include <stdlib.h>

float promedio(float a, float b, float c);

int main(){

    float a, b, c;
    printf("Ingrese el primer numero: ");
    scanf("%f", &a);
    printf("Ingrese el segundo numero: ");
    scanf("%f", &b);
    printf("Ingrese el tercer numero: ");
    scanf("%f", &c);

    printf("\nEl promedio es: %.2f", promedio(a, b, c));

    return 0;
}

float promedio(float a, float b, float c){
    return (a + b + c) / 3;
}