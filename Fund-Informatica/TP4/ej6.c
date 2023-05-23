#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){

    srand(time(NULL));

    int vector[10];
    int intentos=3, num, acierto=0;

    for(int i=0; i<10; i++){
        vector[i]=rand()%21;
        printf("%d ", vector[i]);
    }

    while(intentos>0 && acierto==0){
        printf("Ingrese un numero: ");
        scanf("%d", &num);

        for(int i=0; i<10; i++){
            if(num == vector[i]){
                printf("El numero %d se encuentra en la posicion %d\n", num, i);
                acierto=1;
            }
        }
        intentos--;
    }

    if(acierto==0){
        printf("No se encontro el numero\n");
    }

    return 0;
}