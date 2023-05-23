#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){

    float n1,n2,n3;
    n1=0;
    n2=0;
    n3=0;
    
    while (n1<=0){
        printf("Ingrese el primer numero: ");
        scanf("%f",&n1);  
    }
    while (n2<=0){
        printf("Ingrese el segundo numero: ");
        scanf("%f",&n2);  
    }
    while (n3<=0){
        printf("Ingrese el tercer numero: ");
        scanf("%f",&n3);  
    }

    if(n1>n2 && n2>n3){
        printf("El mayor es %.1f, el del medio es %.1f y el menor es %.1f",n1,n2,n3);
    }
    else if(n1>n3 && n3>n2){
        printf("El mayor es %.1f, el del medio es %.1f y el menor es %.1f",n1,n3,n2);
    }
    else if(n2>n3 && n3>n1){
        printf("El mayor es %.1f, el del medio es %.1f y el menor es %.1f",n2,n3,n1);
    }
    else if(n2>n1 && n1>n3){
        printf("El mayor es %.1f, el del medio es %.1f y el menor es %.1f",n2,n1,n3);
    }
    else if(n3>n2 && n2>n1){
        printf("El mayor es %.1f, el del medio es %.1f y el menor es %.1f",n3,n2,n1);
    }
    else if(n3>n1 && n1>n2){
        printf("El mayor es %.1f, el del medio es %.1f y el menor es %.1f",n3,n1,n2);
    }
    

    return 0;

}