#include <stdio.h>
#include <stdlib.h>

int main()
{
    int anio;

    printf("Introduzca un a%co: ",164);
    scanf("%d",&anio);

    if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0){
        printf("Es bisiesto");
    }
    else{
        printf("No es bisiesto");
    }
    return 0;
}