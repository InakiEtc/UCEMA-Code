#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){

    int mat[3][3];
    int esqui=0,diag=0;
    srand(time(NULL));

    for(int i=0; i<3; i++){
        for(int j=0; j<3; j++){
            mat[i][j] = rand() % 11;
            printf("%d \t",mat[i][j]);
        }
        printf("\n");
    }
    esqui = mat[0][0] + mat[0][2] + mat[2][0] + mat[2][2]; // ej17
    printf("\nLa esqui de las esquinas es: %d",esqui); // ej17

    diag = mat[0][0] + mat[1][1] + mat[2][2]; // ej18
    printf("\nLa suma de la diagonal principal es: %d \n",diag); // ej18

    return 0;
}