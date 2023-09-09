#include <stdio.h>
#include <stdlib.h>

typedef struct Persona{
    char nombre[20];
    char apellido[20];
    int edad;
    int dni;
} Persona;

void cargar_datos(Persona *vector);

int main(){

    //crear un vector de estructura de tamana ingresado por el usuario
    int tam;
    printf("Ingrese el tamano del vector: ");
    scanf("%d", &tam);

    Persona *vector = (Persona *)malloc(tam * sizeof(struct Persona));

    for(int i = 0; i < tam; i++){
        cargar_datos(&vector[i]);
    }

    for(int i = 0; i < tam; i++){
        printf("Persona %d: %s %s %d %d\n", i+1, vector[i].nombre, vector[i].apellido, vector[i].edad, vector[i].dni);
    }

    free(vector);

    return 0;
}

void cargar_datos(Persona *vector){
    printf("Ingrese el nombre de la persona: ");
    fflush(stdin);
    gets(vector->nombre);

    printf("Ingrese el apellido de la persona: ");
    fflush(stdin);
    gets(vector->apellido);

    printf("Ingrese la edad de la persona: ");
    scanf("%d", &vector->edad);

    printf("Ingrese el DNI de la persona: ");
    scanf("%d", &vector->dni);

    printf("\n");

    return;    
}