#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){

    int num;
    printf("Ingrese una numero: ");
    scanf("%d",&num);

    //if (num==0){ //ej5
    if (num<=0){ //ej6
        //printf("No te puedo decir si es par o impar"); // ej5
        printf("El numero no puede ser 0 o negativo"); // ej6
    }
    else if(num%2==0){
        printf("El numero ingresado es par \n");
        printf("El numero elevado al cuadrado es: %.1lf",pow(num,2)); //ej6
    }
    else{
        printf("El numero ingresado es impar \n");
        printf("El numero elevado al cubo es: %.1lf",pow(num,3)); //ej6
    }

    return 0;

}