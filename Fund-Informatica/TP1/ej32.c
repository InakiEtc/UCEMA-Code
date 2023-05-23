#include <stdio.h>
#include <stdlib.h>

int main(){      

    float met;
    
    printf("Ingrese la cantidad de metros: ");
    scanf("%f",&met);


    printf("%.4f metros son %.4f pies \n",met,met*3.2808);

    return 0;
    
}