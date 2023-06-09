#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

typedef struct {
    char nombre[20];
    char apellido[20];
    int legajo;
    char materia[5][20];
    float nota[5];
    float promedio;
}Alumno;

int main(){

    Alumno alumnos[4];
    float mejorPromedio = 0;
    int iMejorPromedio = 0;

    for(int i = 0; i < 4; i++){
        printf("Ingrese el nombre del alumno %d: ", i+1);
        fflush(stdin);
        gets(alumnos[i].nombre);
        printf("Ingrese el apellido del alumno %d: ", i+1);
        fflush(stdin);
        gets(alumnos[i].apellido);
        printf("Ingrese el legajo del alumno %d: ", i+1);
        scanf("%d", &alumnos[i].legajo);
        for(int j = 0; j < 5; j++){
            printf("Ingrese el nombre de la materia %d: ", j+1);
            fflush(stdin);
            scanf(" %s", &alumnos[i].materia[j]);
            printf("Ingrese la nota de la materia %d: ", j+1);
            scanf("%f", &alumnos[i].nota[j]);

            alumnos[i].promedio += alumnos[i].nota[j];                    
        }       
        alumnos[i].promedio /= 5;

        system("cls");
    }

    for(int i = 0; i < 4; i++){
        printf("Nombre: %s\n", alumnos[i].nombre);
        printf("Apellido: %s\n", alumnos[i].apellido);
        printf("Legajo: %d\n", alumnos[i].legajo);
        for(int j = 0; j < 5; j++){
            printf("Materia %d: %s\n", j+1, alumnos[i].materia[j]);
            printf("Nota %d: %.2f\n", j+1, alumnos[i].nota[j]);
        }
        printf("Promedio: %.2f\n", alumnos[i].promedio);
        printf("\n");

        if(alumnos[i].promedio > mejorPromedio){
            mejorPromedio = alumnos[i].promedio;
            iMejorPromedio = i;
        }
    }

    printf("Presione una tecla para continuar");
    getch();
    system("cls");

    printf("Mejor promedio: %s %s\n", alumnos[iMejorPromedio].nombre, alumnos[iMejorPromedio].apellido);

    return 0;

}