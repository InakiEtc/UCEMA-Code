#include <stdio.h>
#include <stdlib.h>

typedef struct Empleado{
    long id_Empleado;
    char nombre[20];
    char apellido[20];
    float sueldo;
    int status;
}Empleado;

void cargarEmpleado(Empleado *e, FILE *archivo, char *nombreArchivo);
void BuscarEmpleado0(Empleado *e, FILE *archivo, char *nombreArchivo);
void exportarDatos(Empleado *e, FILE *archivo, char *nombreArchivo);

int main(){

    Empleado *e = NULL;
    int opcion;
    FILE *archivo = NULL;
    char *nombreArchivo="D:/UCEMA/Programacion1/TP2/archivos/Empleados.bin";


    do{
        printf("1. Cargar nuevo empleado \n");
        printf("2. Buscar empleado inactivos \n");
        printf("3. Exportar datos \n");
        printf("4. Salir \n");
        printf("Elija una opcion: ");
        scanf("%d",&opcion);

        switch(opcion){
            case 1:
                cargarEmpleado(e,archivo,nombreArchivo);             
                break;  
            case 2:
                BuscarEmpleado0(e,archivo,nombreArchivo);
                break;
            case 3:
                exportarDatos(e,archivo,nombreArchivo);
                break;
            case 4:
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

    }while(opcion != 4);  

    return 0;
}

void cargarEmpleado(Empleado *e, FILE *archivo, char *nombreArchivo){
    system("cls");

    e = (Empleado *)malloc(sizeof(Empleado));

    printf("Ingrese el id del empleado: ");
    scanf("%ld", &(e->id_Empleado));
    printf("Ingrese el nombre del empleado: ");
    fflush(stdin);
    gets(e->nombre);
    printf("Ingrese el apellido del empleado: ");
    fflush(stdin);
    gets(e->apellido);
    printf("Ingrese el sueldo del empleado: ");
    scanf("%f",&(e->sueldo));
    do{
        printf("Ingrese el status del empleado (0 o 1): ");
        scanf("%d",&(e->status));
    }while(e->status != 0 && e->status != 1);

    archivo = fopen(nombreArchivo,"ab");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }

    fwrite(e,sizeof(Empleado),1,archivo);
    fputc('\n',archivo);
    fclose(archivo);
    free(e);

    printf("Empleado cargado correctamente \n");
    system("Pause");
    system("cls");
}

void BuscarEmpleado0(Empleado *e, FILE *archivo, char *nombreArchivo){
    system("cls");

    archivo = fopen(nombreArchivo,"rb");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }

    e = (Empleado *)malloc(sizeof(Empleado));

    printf("Empleados inactivos: \n");   
    while (!feof(archivo)){
        size_t bytesRead = fread(e,sizeof(Empleado),1,archivo);
        if (bytesRead > 0) {
            if(e->status == 0){
                printf("\nID: %ld \n",e->id_Empleado);
                printf("Nombre: %s \n",e->nombre);
                printf("Apellido: %s \n",e->apellido);
                printf("Sueldo: %.2f \n",e->sueldo);
                printf("Status: %d \n",e->status);                
            }               
        }
        fgetc(archivo);
    }

    fclose(archivo);
    free(e); 
    system("Pause");
    system("cls");
}

void exportarDatos(Empleado *e, FILE *archivo, char *nombreArchivo){
    system("cls");

    archivo = fopen(nombreArchivo,"rb");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }

    e = (Empleado *)malloc(sizeof(Empleado));

    FILE *archivo2 = NULL;
    char *nombreArchivo2="D:/UCEMA/Programacion1/TP2/archivos/EmpleadosInactivos.txt";

    archivo2 = fopen(nombreArchivo2,"wb");
    if(archivo2 == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }

    printf("Empleados inactivos: \n");   
    while (!feof(archivo)){
        size_t bytesRead = fread(e,sizeof(Empleado),1,archivo);
        if (bytesRead > 0) {
            if(e->status == 0){            
                fprintf(archivo2,"ID: %ld \n",e->id_Empleado);
                fprintf(archivo2,"Nombre: %s \n",e->nombre);
                fprintf(archivo2,"Apellido: %s \n",e->apellido);
                fprintf(archivo2,"Sueldo: %.2f \n",e->sueldo);
                fprintf(archivo2,"Status: %d \n",e->status);
                fputc('\n',archivo2);                
            }               
        }
        fgetc(archivo);
    }

    fclose(archivo);
    fclose(archivo2);
    free(e); 
    system("Pause");
    system("cls");
}