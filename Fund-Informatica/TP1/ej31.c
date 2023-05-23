#include <stdio.h>
#include <stdlib.h>

int main(){      

    float cent;
    
    printf("Ingrese la cantidad de centimetros: ");
    scanf("%f",&cent);


    printf("%.4f centimetros son %.4f pulgadas \n",cent,cent*0.39737);

    return 0;
    
}
