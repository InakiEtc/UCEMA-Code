#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){

    // int m1[4][4] = {{0,2,5,5},{1,1,0,6},{4,3,0,0},{5,3,0,2}}; //ej23
    int m1[4][4];
    srand(time(NULL));

    for (int i=0; i<4; i++){
        for (int j=0; j<4; j++){
            m1[i][j] = rand() % 17;
            printf("%d ", m1[i][j]);
        }
        printf("\n");
    } //ej24

    char *alumnos[4] = {"Juan", "Jose", "Maria", "Pedro"};
    char *materias[4] = {"Matematica", "Fisica", "Quimica", "Biologia"};

    for (int a=0; a<4; a++){ //alumnos
        for (int m=0; m<4; m++){ //materias
            if (m1[a][m] >= 16*0.25){
                printf("%s quedo libre en %s \n", alumnos[a], materias[m]);
            }   
        }
    }
    
    return 0;
}