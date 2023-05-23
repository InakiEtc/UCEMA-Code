#include <stdio.h>
#include <stdlib.h>

int main(){

    int a,b,res;
    printf("ingrese el primer num: ");
    scanf("%d",&a);
    printf("ingrese el segundo num: ");
    scanf("%d",&b);
    res=(a-b)*(a+b);
    printf("la ecuacion da: %d",res);

    return 0;

}
