#include <stdio.h>
#include <stdlib.h>

float cuadrado(float num);

int main(){

    float num,res;
    printf("Ingrese un numero: ");
    scanf("%f", &num);
    res = cuadrado(num);
    printf("El cuadrado de %.1f es %.2f\n", num, res);

    return 0;
}

float cuadrado(float num){
    return num*num;
}