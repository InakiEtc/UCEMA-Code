#include <stdio.h>
#include <stdlib.h>

typedef struct{
    char nombre[20];
    char apellido[20];
    float horasTrabajadas;
    float valorHora;
    float salario;
}Empleado;

int main(){
    Empleado empleados[5];

    for(int i = 0; i < 5; i++){
        printf("Ingrese el nombre del empleado %d: ", i+1);
        fflush(stdin);
        gets(empleados[i].nombre);
        printf("Ingrese el apellido del empleado %d: ", i+1);
        fflush(stdin);
        gets(empleados[i].apellido);
        printf("Ingrese las horas trabajadas del empleado %d: ", i+1);
        scanf("%f", &empleados[i].horasTrabajadas);
        printf("Ingrese el valor de la hora del empleado %d: ", i+1);
        scanf("%f", &empleados[i].valorHora);
        empleados[i].salario = empleados[i].horasTrabajadas * empleados[i].valorHora;

        system("cls");
    }

    float menorSalario = empleados[0].salario;
    int indiceMenorSalario = 0;
    for(int i = 1; i < 5; i++){
        if(empleados[i].salario < menorSalario){
            menorSalario = empleados[i].salario;
            indiceMenorSalario = i;
        }
    }

    for(int i = 0; i < 5; i++){
        printf("El salario del empleado %s %s es: %.2f\n", empleados[i].nombre, empleados[i].apellido, empleados[i].salario);
    }
    printf("\n");
    printf("El empleado que gana menos es: %s %s\n", empleados[indiceMenorSalario].nombre, empleados[indiceMenorSalario].apellido);
    printf("Su salario es: %.2f\n", empleados[indiceMenorSalario].salario);

    return 0;

}