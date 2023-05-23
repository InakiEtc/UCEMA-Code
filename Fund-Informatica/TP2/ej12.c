#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){

    float gc,fh;
    printf("Ingrese una cantidad de grados centigrados: ");
    scanf("%f",&gc);
    
    fh=(( gc * 9/5) + 32);
    printf("%.2f grados centigrados son %.2f grados Fahrenheit \n",gc,fh);

    if (gc<-89.5){
        printf("Se ha introducido un valor inferior a la menor temperatura registrada en la superficie de la Tierra");
    }
    else if(gc<=0){
        printf("El agua se encuentra en estado solido.");
    }
    else if(gc>0 && gc<100){
        printf("El agua se encuentra en estado liquido.");
    }
    else if(gc>=100 && gc<121){
        printf("El agua se encuentra en estado gaseoso.");
    }
    else{
        printf("Se ha superado la mayor temperatura conocida que soporta vida.");
    }

    return 0;
    
}
