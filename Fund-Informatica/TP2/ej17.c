#include <stdio.h>
#include <stdlib.h>

int main(){

    int gr;
    printf("Ingrese el valor del angulo: ");
    scanf("%d",&gr);
    
    if (gr>=0 && gr<=360){
        if (gr == 0){ printf("Angulo Llano"); }
        else if (gr < 90){ printf("Angulo Agudo"); }   
        else if (gr == 90){ printf("Angulo Recto"); }   
        else if (gr > 90 && gr < 180){ printf("Angulo Obtuso"); }
        else if (gr == 180){ printf("Angulo Llano"); }
        else if (gr > 180 && gr < 360){ printf("Angulo Concavo"); }   
        else if (gr == 360){ printf("Angulo Completo"); }
    }
    else{
        printf("Ingrese un angulo entre 0 y 360 grados...");
    }

    return 0;
}