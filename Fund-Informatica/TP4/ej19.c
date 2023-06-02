#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){
    int matriz[3][4];
    int pares = 0, impares = 0;
    srand(time(NULL));

    for(int i = 0; i < 3; i++){
        for(int j = 0; j < 4; j++){
            matriz[i][j] = rand() % 21;
            printf("%d \t", matriz[i][j]);
            if(matriz[i][j] % 2 == 0){
                pares++;
            }else{
                impares++;
            }
        }
        printf("\n");
    }

    printf("La matriz tiene %d numeros pares y %d numeros impares\n", pares, impares);

    return 0;
}
