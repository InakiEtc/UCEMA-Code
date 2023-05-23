#include <stdio.h>
#include <stdlib.h>

int main(){

    int dias;
    printf("ingrese una cant de dias: ");
    scanf("%d",&dias);

    printf("%d dias son %d minutos \n",dias,dias*1440);
    printf("%d dias son %d segundos",dias,dias*86400);
    
    return 0;

}
