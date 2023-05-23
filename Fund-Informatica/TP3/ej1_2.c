#include <stdio.h>
#include <stdlib.h>

int main(){

    int num;
    printf("Ingrese un numero: ");
    scanf("%d",&num);

    for (int i = 0; i < 50; i++){
        /* ej 1
        if (i==49){
            printf("%d",num);
        }
        else{
            printf("%d-",num);
        }
        */
        printf("\t%d \n \n",num);//ej 2
    }

    return 0;
}