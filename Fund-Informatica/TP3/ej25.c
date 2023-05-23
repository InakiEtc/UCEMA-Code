#include <stdio.h>
#include <stdlib.h>

int main(){

    int num,cont=0,suma=0;

    printf("Ingrese un numero, un num par corta el prg: ");
    scanf("%d",&num);
    
    while (num%2 != 0){
        suma += num;
        cont++;

        printf("Ingrese un numero, un num par corta el prg: ");
        scanf("%d",&num);
    } 

    printf("Ingreso %d numeros impares \n",cont);
    printf("El promedio de los numeros impares es: %d",suma/cont);
    return 0;
}