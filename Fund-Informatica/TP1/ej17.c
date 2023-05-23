#include <stdio.h>
#include <stdlib.h>
#include <math.h>


int main(){

    float a,b,c,x1,x2,disc;
    printf("Ingrese el termino cuadratico: ");
    scanf("%f",&a);
    printf("Ingrese el termino lineal: ");
    scanf("%f",&b);
    printf("Ingrese el termino independiente: ");
    scanf("%f",&c);

    disc=(b*b-4*a*c);
    if (disc < 0){
        printf("No se puede resolver");
    }else{
        disc=sqrtf(disc);
        x1=((-b+disc)/(2*a));
        x2=((-b-disc)/(2*a));
        printf("Las raices son x1= %.2f y x2= %.2f",x1,x2);

    }    
    return 0;

}
