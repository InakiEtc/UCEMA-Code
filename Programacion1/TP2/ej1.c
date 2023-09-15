#include <stdio.h>
#include <stdlib.h>

void agregarAlumnos(FILE *archivo, char *nombreArchivo);
void mostrarAlumnos(FILE *archivo, char *nombreArchivo);

int main(){

    int opcion;
    FILE *archivo=NULL;
    char * nombreArchivo="D:/UCEMA/Programacion1/TP2/archivos/Alumnos.txt";
  
    do{
        printf("1. Agregar Alumnos al archivo \n");
        printf("2. Ver Alumnos del archivo \n");
        printf("3. Salir \n");
        printf("Elija una opcion: ");
        scanf("%d",&opcion);

        switch(opcion){
            case 1:
                agregarAlumnos(archivo,nombreArchivo);                
                break;  
            case 2:
                mostrarAlumnos(archivo,nombreArchivo);
                break;
            case 3:
                system("cls");
                printf("Saliendo... \n");
                break;
            default:
                system("cls");
                printf("Opcion Invalida \n");
                system("Pause");
                system("cls");
                break;                
        }
    }while (opcion != 3);   
    return 0;
}

void agregarAlumnos(FILE *archivo, char *nombreArchivo){
    
    system("cls");
    char nombre[20];
    
    archivo=fopen(nombreArchivo,"a");

    if(archivo==NULL){
        printf("Error al abrir el archivo \n");
        return;
    }

    do{
        printf("Ingrese el nombre del alumno, para cejar de agregar ingrese 0: ");
        fflush(stdin);
        gets(nombre);

        if (nombre[0] == '0'){
            break;
        }
        fprintf(archivo,"- %s\n",nombre);

    }while(1);  

    fclose(archivo);
    system("cls");
}

void mostrarAlumnos(FILE *archivo, char *nombreArchivo){
    system("cls");
    char nombre[20];
    
    archivo=fopen(nombreArchivo,"r");

    if(archivo==NULL){
        printf("Error al abrir el archivo \n");
        return;
    }

    while(!feof(archivo)){
        fgets(nombre,20,archivo);
        printf("%s",nombre);
    }

    fclose(archivo);
    system("Pause");
    system("cls");
}
