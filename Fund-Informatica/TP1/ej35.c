#include <stdio.h>
#include <stdlib.h>

int main(){

    int hor;

    printf("Ingrese el valor en horas: ");
    scanf("%d",&hor);

    printf("%d hora/s son %d minutos \n",hor,hor * 60);
    printf("%d hora/s son %d segundos",hor,hor * 3600);

    return 0;

}