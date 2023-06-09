#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

typedef struct{
    char titulo[20];
    char autor[20];
    char genero[20];
    float precio;
    float puntaje;
}Libro;

int main(){

    Libro libros[3];

    for(int i = 0; i < 3; i++){
        printf("Ingrese el titulo del libro %d: ", i+1);
        fflush(stdin);
        gets(libros[i].titulo);
        printf("Ingrese el autor del libro %d: ", i+1);
        fflush(stdin);
        gets(libros[i].autor);
        printf("Ingrese el genero del libro %d: ", i+1);
        fflush(stdin);
        gets(libros[i].genero);
        printf("Ingrese el precio del libro %d: ", i+1);
        scanf("%f", &libros[i].precio);
        printf("Ingrese el puntaje del libro %d: ", i+1);
        scanf("%f", &libros[i].puntaje);

        system("cls");
    }

    for(int i = 0; i < 3; i++){
        printf("Libro %d\n", i+1);
        printf("Titulo: %s\n", libros[i].titulo);
        printf("Autor: %s\n", libros[i].autor);
        printf("Genero: %s\n", libros[i].genero);
        printf("Precio: %.2f\n", libros[i].precio);
        printf("Puntaje: %.2f\n", libros[i].puntaje);
        printf("\n");
    }

    printf("Presione una tecla para continuar");
    getch();
    system("cls");

    int mayor = 0;
    for(int i = 0; i < 3; i++){
        if(libros[i].puntaje > libros[mayor].puntaje){
            mayor = i;
        }
    }
    printf("El favorito de todos es... \n");
    printf("Titulo: %s\n", libros[mayor].titulo);
    printf("Autor: %s\n", libros[mayor].autor);
    printf("Genero: %s\n", libros[mayor].genero);
    printf("Precio: %.2f\n", libros[mayor].precio);
    printf("Puntaje: %.2f\n", libros[mayor].puntaje);
    printf("\n");

    return 0;
}