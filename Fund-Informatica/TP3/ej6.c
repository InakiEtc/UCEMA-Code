#include <stdio.h>
#include <stdlib.h>

int main(){

    int num;
    printf("Ingrese un numero: ");
    scanf("%d",&num);

    printf("\nTabla del %d: \n",num);
    printf("------------ \n");

    for (int i = 0; i < 11; i++){
        printf("%d x %d = %d \n",num,i,num*i);
    }

    return 0;
}