#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){

    int f, c;
    printf("Ingrese la cantidad de filas: ");
    scanf("%d", &f);
    printf("Ingrese la cantidad de columnas: ");
    scanf("%d", &c);
    
    int m1[f][c];
    int m2[f][c];
    int suma[f][c];
    int prod[f][c];
    int tras[f][c];

    srand(time(NULL));

    for(int i = 0; i < f; i++){
        for(int j = 0; j < c; j++){
            m1[i][j] = rand() % 11;
            m2[i][j] = rand() % 11;
            suma[i][j] = m1[i][j] + m2[i][j];
        }
    }

    if(f != c){
        printf("No se puede multiplicar, por lo tanto tampoco trasponerla\n");
    }
    else{
        for(int i = 0; i < f; i++){
            for(int j = 0; j < c; j++){
                prod[i][j] = 0;
                for(int k = 0; k < 3; k++){
                    prod[i][j] += m1[i][k] * m2[k][j];
                }
            }
        }
        
        for(int i = 0; i < f; i++){
            for(int j = 0; j < c; j++){
                tras[i][j] = prod[j][i];
            }
        }
    }

    printf("Matriz 1:\n");
    for(int i = 0; i < f; i++){
        for(int j = 0; j < c; j++){
            printf("%d \t", m1[i][j]);
        }
        printf("\n");
    }

    printf("Matriz 2:\n");
    for(int i = 0; i < f; i++){
        for(int j = 0; j < c; j++){
            printf("%d \t", m2[i][j]);
        }
        printf("\n");
    }

    printf("Suma:\n");
    for(int i = 0; i < f; i++){
        for(int j = 0; j < c; j++){
            printf("%d \t", suma[i][j]);
        }
        printf("\n");
    }

    if(f != c){
        printf("No Tiene matriz producto y traspuesta\n");
    }
    else{
        printf("Producto:\n");
        for(int i = 0; i < f; i++){
            for(int j = 0; j < c; j++){
                printf("%d \t", prod[i][j]);
            }
            printf("\n");
        }

        printf("Traspuesta del producto:\n");
        for(int i = 0; i < f; i++){
            for(int j = 0; j < c; j++){
                printf("%d \t", tras[i][j]);
            }
            printf("\n");
        }
    }

    return 0;
}