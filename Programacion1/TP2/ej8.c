#include <stdio.h>
#include <stdlib.h>

typedef struct Alumno{    
    char Nombre[20];
    char Apellido[20];
    int edad;
    int anio;
    float promedio;
}Alumno;

void cargarAlumno(Alumno *a, FILE *archivo, char *nombreArchivo);
void listarAlumnos20(Alumno a, FILE *archivo, char *nombreArchivo);
void listarAlumnos(Alumno a, FILE *archivo, char *nombreArchivo);
void export(Alumno a,FILE *archivo, char *nombreArchivo);

int main(){

    int opcion;
    FILE *archivo = NULL;
    char *nombreArchivo="D:/UCEMA/Programacion1/TP2/archivos/Alumnos.bin";    
    Alumno a;

    do{
        printf("1. Cargar alumno \n");
        printf("2. Listar alumnos mayores de 20 inclusive \n");
        printf("3. Listar alumnos \n");
        printf("4. Exportar \n");
        printf("5. Salir \n");
        printf("Elija una opcion: ");
        scanf("%d",&opcion);

        switch(opcion){
            case 1:
                cargarAlumno(&a,archivo,nombreArchivo);             
                break;  
            case 2:
                listarAlumnos20(a,archivo,nombreArchivo);
                break;
            case 3:
                listarAlumnos(a,archivo,nombreArchivo);
                break;
            case 4:
                export(a,archivo,nombreArchivo);
                break;
            case 5:
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
    }while (opcion != 5); 

    return 0;
}

void cargarAlumno(Alumno *a, FILE *archivo, char *nombreArchivo){
    system("cls");
    archivo = fopen(nombreArchivo,"ab");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }

    printf("Ingrese el nombre del alumno: ");
    fflush(stdin);
    gets(a->Nombre);

    printf("Ingrese el apellido del alumno: ");
    fflush(stdin);
    gets(a->Apellido);

    printf("Ingrese la edad del alumno: ");
    scanf("%d",&a->edad);

    printf("Ingrese el anio del alumno: ");
    scanf("%d",&a->anio);

    printf("Ingrese el promedio del alumno: ");
    scanf("%f",&a->promedio);

    fwrite(a,sizeof(Alumno),1,archivo);
    fclose(archivo);    
    printf("\n");
    printf("Alumno cargado correctamente \n");
    system("Pause");
    system("cls"); 
}

void listarAlumnos20(Alumno a, FILE *archivo, char *nombreArchivo){
    system("cls");
    archivo = fopen(nombreArchivo,"rb");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }

    int flag = 0;
    printf("Lista de Alumnos mayores a 20 inclusive: \n");   
    while(!feof(archivo)){
        size_t bytesRead = fread(&a,sizeof(Alumno),1,archivo);
        if (bytesRead > 0) {
            if(a.edad >= 20){
                printf("\nNombre: %s \n",a.Nombre);
                printf("Apellido: %s \n",a.Apellido);
                printf("Edad: %d \n",a.edad);
                flag = 1;
            }
        }
    }
    if(flag == 0){
        printf("No hay alumnos mayores a 20 \n");
    }

    fclose(archivo);
    printf("\n");
    system("Pause");
    system("cls");
}

void listarAlumnos(Alumno a, FILE *archivo, char *nombreArchivo){
    system("cls");
    archivo = fopen(nombreArchivo,"rb");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }

    printf("Lista de Alumnos: \n");   
    while(!feof(archivo)){
        size_t bytesRead = fread(&a,sizeof(Alumno),1,archivo);
        if (bytesRead > 0) {
            printf("\nNombre: %s \n",a.Nombre);
            printf("Apellido: %s \n",a.Apellido);
            printf("Edad: %d \n",a.edad);
            printf("Anio: %d \n",a.anio);
            printf("Promedio: %.2f \n",a.promedio);
        }
    }

    fclose(archivo);
    printf("\n");
    system("Pause");
    system("cls");    
}

void export(Alumno a,FILE *archivo, char *nombreArchivo){
    system("cls");
    archivo = fopen(nombreArchivo,"rb");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }

    FILE *archivo2 = NULL;
    char *nombreArchivo2="D:/UCEMA/Programacion1/TP2/archivos/export.txt"; 
    archivo2 = fopen(nombreArchivo2,"w");
    if(archivo2 == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }
  
    while(!feof(archivo)){
        size_t bytesRead = fread(&a,sizeof(Alumno),1,archivo);
        if (bytesRead > 0) {
            if(a.promedio >= 9){
                fprintf(archivo2,"Nombre: %s \n",a.Nombre);
                fprintf(archivo2,"Apellido: %s \n",a.Apellido);
                fprintf(archivo2,"Edad: %d \n",a.edad);
                fputc('\n',archivo2);    
            }            
        }
    }

    fclose(archivo);
    fclose(archivo2);
    printf("Archivo exportado correctamente \n");
    system("Pause");
    system("cls");
}