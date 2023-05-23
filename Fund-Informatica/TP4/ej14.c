#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

int main(){

    //Hacer un programa que permita ingresar el nombre y apellido de dos personas. Verificar si se llaman igual (ya sea de nombre o de apellido).

    char nombre1[50], nombre2[50], apellido1[50], apellido2[50];

    printf("Ingrese el nombre de la primera persona: ");
    fflush(stdin);
    gets(nombre1);
    printf("Ingrese el apellido de la primera persona: ");
    fflush(stdin);
    gets(apellido1);
    printf("Ingrese el nombre de la segunda persona: ");
    fflush(stdin);
    gets(nombre2);
    printf("Ingrese el apellido de la segunda persona: ");
    fflush(stdin);
    gets(apellido2);

    if(strcmp(nombre1, nombre2) == 0 ){
        printf("Las personas tienen el mismo nombre.");
    }
    else if(strcmp(apellido1, apellido2) == 0){
        printf("Las personas tienen el mismo apellido.");
    }
    else{
        printf("Las personas no se llaman igual.");
    }  

    return 0;
}