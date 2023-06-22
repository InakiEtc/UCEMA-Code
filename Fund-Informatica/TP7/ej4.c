#include <stdio.h>
#include <stdlib.h>

void func_producto(int *res);

int main(){

    int a, b, res;

    printf("Ingrese el valor de A: ");
    scanf("%d", &a);
    printf("Ingrese el valor de B: ");
    scanf("%d", &b);

    res = a + b;

    printf("El resultado de la suma de A y B es: %d\n", res);

    func_producto(&res);

    printf("El res de la suma de A y B al cuadrado es: %d\n", res);

    return 0;
}

void func_producto(int *res){
    *res = *res * (*res);
}