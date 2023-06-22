#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define TAM 30

void imprimirVector(int *punteroInicial);
void imprimirDireccion(int *punteroInicial, int *punteroFinal);
void imprimirDato(int *punteroInicial, int *punteroFinal);
void imprimirCentral(int *punteroCentral);

int main(){

    int vector[TAM];
    int *punteroInicial = &vector[0];
    int *punteroFinal = &vector[TAM - 1];
    int *punteroCentral = &vector[15];

    srand(time(NULL));

    for (int i = 0; i < TAM; i++){
        vector[i] = rand() % 501;
    }

    imprimirVector(punteroInicial);
    system("pause");
    system("cls");   

    imprimirDireccion(punteroInicial, punteroFinal);
    system("pause"); 
    system("cls");

    imprimirDato(punteroInicial, punteroFinal);
    system("pause"); 
    system("cls");

    imprimirCentral(punteroCentral);
    system("pause"); 
    system("cls");

    return 0;
}

void imprimirVector(int *punteroInicial){
    printf("Vector : \n");
    for (int i = 0; i < TAM; i++){
        printf("Posicion %d : ", i);
        printf("Direccion de memoria : %p - ", punteroInicial);
        printf("Valor : %d\n", *punteroInicial);
        punteroInicial++;
    }
}

void imprimirDireccion(int *punteroInicial, int *punteroFinal){
    printf("Direccion de memoria del primer elemento : %p\n", punteroInicial);
    printf("Direccion de memoria del ultimo elemento : %p\n", punteroFinal);
}


void imprimirDato(int *punteroInicial, int *punteroFinal){
    printf("Dato del primer elemento : %d\n", *punteroInicial);
    printf("Dato del ultimo elemento : %d\n", *punteroFinal);
}

void imprimirCentral(int *punteroCentral){
    printf("Direccion de memoria del elemento central : %p\n", punteroCentral);
    printf("Dato del elemento central : %d\n", *punteroCentral);
}


