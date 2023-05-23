#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){

    float gc,fh;
    printf("Ingrese una cantidad de grados centigrados: ");
    scanf("%f",&gc);
    
    fh=(( gc * 9/5) + 32);
    printf("%.2f grados centigrados son %.2f grados Fahrenheit",gc,fh);

    return 0;
    
}
