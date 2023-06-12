#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

#define TAM 20

bool chequearVector(bool cargado);
void cargarVector(int vec[]);
void ponerVectorEnCero(int vec[]);
void visualizarVector(int vec[]);
float promedio(int vec[]);

int main(){
    int vec[TAM], opcion;
    float prom;
    bool cargado = false;

    do{
        printf("\n1) Cargar vector\n");
        printf("2) Poner vector en 0\n");
        printf("3) Visualizar vector\n");
        printf("4) Promedio\n");
        printf("5) Salir\n");
        printf("Ingrese una opcion: ");
        scanf("%d", &opcion);

        system("cls");

        switch(opcion){
            case 1:
                cargarVector(vec);
                cargado = true;
                break;
            case 2:
                if(chequearVector(cargado)){ break;}
                ponerVectorEnCero(vec);
                break;
            case 3:
                if(chequearVector(cargado)){ break;}
                visualizarVector(vec);

                system("pause");
                system("cls");
                break;
            case 4:
                if(chequearVector(cargado)){ break;}
                prom = promedio(vec);
                printf("\nEl promedio es: %.2f\n\n", prom);

                system("pause");
                system("cls");
                break;
            case 5:
                printf("\nSaliendo...\n");
                break;
            default:
                printf("\nOpcion incorrecta\n");
        }
    }while(opcion != 5);

    return 0;
}

bool chequearVector(bool cargado){
    if(cargado == false){
        printf("\nPrimero debe cargar el vector\n\n");
        system("pause");
        system("cls");
    }
    else{
        return false;
    }

    return true;
}

void cargarVector(int vec[]){
    for(int i = 0; i < TAM; i++){
        vec[i] = rand() % 101;
    }
}

void ponerVectorEnCero(int vec[]){
    for(int i = 0; i < TAM; i++){
        vec[i] = 0;
    }
}

void visualizarVector(int vec[]){
    for(int i = 0; i < TAM; i++){
        printf("%d ", vec[i]);
    }
    printf("\n");
}

float promedio(int vec[]){
    float prom = 0;
    int suma = 0;

    for(int i = 0; i < TAM; i++){
        printf("%d - ", vec[i]);
        suma += vec[i];
    }
    prom = (float)suma / TAM;

    return prom;
}
 
 
