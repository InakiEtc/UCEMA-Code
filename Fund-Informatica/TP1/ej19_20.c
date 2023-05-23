#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){
    
    /*
    //ejercicio 19
    float num;
    printf("Ingrese un numero: ");
    scanf("%f",&num);

    printf("El cuadrado de num = %.2f \n",num*num);
    printf("El cubo de num es = %.2f",num*num*num);

    */

    //ejercicio 20
    float num;
    printf("  CALCULA EL CUADRADO Y EL CUBO DE UN NRO USANDO LA FUNCION POW  \n");
    printf("----------------------------------------------------------------- \n");
    printf("Ingrese Valor: ");
    scanf("%f",&num);

    printf("El Nro: %.2f elevado al cuadrado es: %.2f \n",num,pow(num,2));
    printf("El Nro: %.2f elevado al cubo es: %.2f \n",num,pow(num,3));

    return 0;
    
}
