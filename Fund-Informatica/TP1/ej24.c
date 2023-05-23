#include <stdio.h>
#include <stdlib.h>

int main(){

    float sum,num;
        
    printf("Ingrese la nota de Quimica: ");
    scanf("%f",&num);
    sum=sum+num;

    printf("Ingrese la nota de Fisica: ");
    scanf("%f",&num);
    sum=sum+num;

    printf("Ingrese la nota de Matematica: ");
    scanf("%f",&num);
    sum=sum+num;

    printf("Ingrese la nota de Informatica: "); 
    scanf("%f",&num);
    sum=sum+num;

    printf("El promedio de las 4 materias es = %.2f",sum/4);

    return 0;
    
}
