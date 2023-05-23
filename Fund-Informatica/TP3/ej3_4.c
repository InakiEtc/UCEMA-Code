#include <stdio.h>
#include <stdlib.h>

int main(){

    int num,par,impar;
    float prm,prmpar;
    prm=0;
    prmpar=0; // ej2
    par=0;
    impar=0;

    for (int i = 0; i < 20; i++){
        printf("Ingrese un numero: ");
        scanf("%d",&num);
        prm=prm+num;

        if (num%2 == 0){
            par++;
            prmpar=prmpar+num; // ej2
        }
        else{
            impar++;
        }
        
    }

    printf("\nHay %d numero/s par/es \n",par);
    printf("Hay %d numero/s impar/es \n",impar);
    printf("El promedio de todos los numeros es %.2f \n",prm/20);
    printf("El promedio de los numeros pares es %.2f",prmpar/par);

    return 0;
}