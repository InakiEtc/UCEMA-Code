#include <stdio.h>
#include <stdlib.h>

int main(){

    int num,mult,valid = 0;

    printf("Ingrese un numero entre 1 y 10, un num fuera de rango corta el prg: ");
    scanf("%d",&num);

    if (num >10 || num<1){
        printf("Debe ingresar minimo dos valores que se puedan multiplicar");
        return 0;
    }
    valid=1;
    mult=num;
     
    while (num <=10 && num>=1){

        printf("Ingrese un numero entre 1 y 10, un num fuera de rango corta el prg: ");
        scanf("%d",&num);

        if (num >10 || num<1){
            if (valid==1){
                printf("Debe ingresar minimo dos valores que se puedan multiplicar");
                return 0;
            }
            break;
        }
        valid=2;
        mult *= num;
    }  

    printf("El producto de los numeros ingresados es: %d",mult);
    return 0;
}