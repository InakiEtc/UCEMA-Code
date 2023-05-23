#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){

    int n1;
    
    printf("Ingrese un numero mayor a 0: ");
    scanf("%d",&n1);  

    if (n1<=0){
        printf("Error: el numero tiene que ser mayor a 0");
    }
    else if (log10(n1)>4){ 
        printf("El numero ingresado tiene mas de 4 cifras");
    }
    else{
        printf("El numero ingresado tiene menos de 4 cifras");
    }

    return 0;

}