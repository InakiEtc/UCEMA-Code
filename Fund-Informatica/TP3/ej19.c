#include <stdio.h>
#include <stdlib.h>

int main(){
    int num, fact = 1;

    printf("Ingrese un numero para calcular su factorial: ");
    scanf("%d",&num);

    for (int b = num; b > 1; b--){
        fact = fact * b;
    }

    printf("%d! = %d",num,fact);

    return 0;
}