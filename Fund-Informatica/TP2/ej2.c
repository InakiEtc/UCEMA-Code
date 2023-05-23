#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){

    
    float num;

    srand(time(NULL));
    num = rand() % 1000;
  
    if(num>100){
        printf("El numero %.2f es mayor a 100",num);
    }
    else{
        printf("El numero %.2f es menor o igual a 100",num);
    }

    return 0;

}