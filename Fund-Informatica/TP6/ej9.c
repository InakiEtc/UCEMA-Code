#include <stdio.h>
#include <stdlib.h>

float salarioExtra(float hsExtras, float precioHora);

int main(){

    float hsExtras, precioHora, salario;

    printf("Ingrese la cantidad de horas extras trabajadas: ");
    scanf("%f", &hsExtras);
    printf("Ingrese el precio de la hora: ");
    scanf("%f", &precioHora);

    salario = salarioExtra(hsExtras, precioHora);

    printf("\nEl salario extra que debera pagarse es: %.2f\n", salario);

    return 0;
}

float salarioExtra(float hsExtras, float precioHora){
    float salario;
    salario = hsExtras * precioHora;

    return salario;
}


