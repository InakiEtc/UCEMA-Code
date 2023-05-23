#include <stdio.h>
#include <stdlib.h>
#include <math.h>
 
int main(){
    float a, b;
    printf("Ingrese el Coeficiente a: ");
    scanf("%f",&a);
    printf("Ingrese el Coeficiente b: ");
    scanf("%f",&b);

    if(a==0){
        printf("La ecuacion no existe ya que a es = 0");
    }
    else{
        printf("El valor de la X es = %.2f",-b/a);
    }
 
    return 0;
}