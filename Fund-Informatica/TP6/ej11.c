#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define MAX 8

void almacenarNumeros(int numeros[]);
void generarNumeros(int numeros[]);
void imprimirNumeros(int numeros[]);
void compararNumeros(int misNumeros[], int numerosGanadores[]);

int main(){

    int misNumeros[MAX], numerosGanadores[MAX];

    almacenarNumeros(misNumeros);
    generarNumeros(numerosGanadores);
    system("cls");

    printf("Mis numeros: ");
    imprimirNumeros(misNumeros);
    printf("Numeros ganadores: ");
    imprimirNumeros(numerosGanadores);

    compararNumeros(misNumeros, numerosGanadores);

    return 0;
}

void almacenarNumeros(int numeros[]){
    for(int i = 0; i < MAX; i++){
        if(i < 6){
            printf("Ingrese un numero (entre 0 y 41): ");
            scanf("%d", &numeros[i]);
            if(numeros[i] < 0 || numeros[i] > 41){
                printf("El numero ingresado no es valido\n");
                i--;
            }
        }
        else{
            printf("Ingrese los numeros del Jackpot (entre 0 y 9): ");
            scanf("%d", &numeros[i]);
            if(numeros[i] < 0 || numeros[i] > 9){
                printf("El numero ingresado no es valido\n");
                i--;
            }
        } 
    }
}

void generarNumeros(int numeros[]){

    srand(time(NULL));
    for(int i = 0; i < 6; i++){
        numeros[i] = rand() % 42;
    }
    for(int i = 6; i < MAX; i++){
        numeros[i] = rand() % 10;
    }   
}

void imprimirNumeros(int numeros[]){
    for(int i = 0; i < MAX; i++){
        printf("%d ", numeros[i]);
    }
    printf("\n\n");
}

void compararNumeros(int misNumeros[], int numerosGanadores[]){
    int aciertos = 0;
    int aciertosJackpot = 0;
    for(int i = 0; i < 6; i++){
        for(int j = 0; j < 6; j++){
            if(misNumeros[i] == numerosGanadores[j]){
                aciertos++;
            }
        }
    }

    for(int i = 6; i < MAX; i++){
        for(int j = 6; j < MAX; j++){
            if(misNumeros[i] == numerosGanadores[i]){
                aciertosJackpot++;
            }
        }
    }   

    if(aciertos+aciertosJackpot == 8){
        printf("Ganaste el pozo!!\n");
        
    }
    else if(aciertos+aciertosJackpot == 0){
        printf("No acertaste ningun numero\n");
    }
    else if(aciertosJackpot == 2 && aciertos == 0){
        printf("Acertaste los 2 del Jackpot, Ganaste $1.000!\n");
    }
    else if(aciertosJackpot == 1 && aciertos == 0){
        printf("No ganaste nada pero acertaste 1 del Jackpot\n");
    }
    else if(aciertos == 6){
        printf("Acertaste 6 numeros, Ganaste $1.000.000!\n");
    }
    else if(aciertos == 5){
        printf("Acertaste 5 numeros, Ganaste $100.000!\n");
    }
    else if(aciertos == 4){
        printf("Acertaste 4 numeros, Ganaste $10.000!\n");
    }
    else if(aciertos == 3){
        printf("No ganaste nada pero acertaste estos 3 numeros: ");
        for(int i = 0; i < 6; i++){
            for(int j = 0; j < 6; j++){
                if(misNumeros[i] == numerosGanadores[j]){
                    printf("%d ", misNumeros[i]);
                }
            }
        }
    }
    else if(aciertos == 2){
        printf("No ganaste nada pero acertaste estos 2 numeros: ");
        for(int i = 0; i < 6; i++){
            for(int j = 0; j < 6; j++){
                if(misNumeros[i] == numerosGanadores[j]){
                    printf("%d ", misNumeros[i]);
                }
            }
        }
    }
    else if(aciertos == 1){
        printf("No ganaste nada pero acertaste este numero: ");
        for(int i = 0; i < 6; i++){
            for(int j = 0; j < 6; j++){
                if(misNumeros[i] == numerosGanadores[j]){
                    printf("%d ", misNumeros[i]);
                }
            }
        }
    }  
}