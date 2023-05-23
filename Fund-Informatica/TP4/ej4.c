#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){

    srand(time(NULL));

    int vector[5000];
    int d=0, v=0, t=0;
    
    for(int i=0; i<5000; i++){
        vector[i] = rand() % 31;
        if(vector[i] == 10){
            d++;
        }
        else if(vector[i] == 20){
            v++;
        }
        else if(vector[i] == 30){
            t++;
        }
    }
    printf("El numero 10 aparece %d veces\n", d);
    printf("El numero 20 aparece %d veces\n", v);
    printf("El numero 30 aparece %d veces\n", t);

    return 0;
}