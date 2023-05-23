#include <stdio.h>
#include <stdlib.h>

int main(){

    
    int a,b,c,aux;

    printf("Ingrese el valor de a: ");
    scanf("%d",&a);
    printf("Ingrese el valor de b: ");
    scanf("%d",&b);
    printf("Ingrese el valor de c: ");
    scanf("%d",&c);

    aux=c;
    c=3*b;
    b=a+aux;
    a=2*aux;       

    printf("a = %d \n",a);
    printf("b = %d \n",b);
    printf("c = %d \n",c);

    return 0;

}