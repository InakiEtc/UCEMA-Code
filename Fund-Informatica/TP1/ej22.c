#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){

    int num,sum;
    printf("  CALCULA EL PROMEDIO DE UN 5 NUMEROS  \n");
    printf("-------------------------------------- \n");
    for (int i = 0; i < 5; i++){
        printf("Ingrese un Numero: ");
        scanf("%d",&num);
        sum=sum+num;
    }
    
    printf("La suma da %d  \n",sum);
    printf("El promedio de la suma es = %d",sum/5);

    return 0;
    
}
