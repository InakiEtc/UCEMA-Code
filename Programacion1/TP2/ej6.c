#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct Auto{    
    char Marca[20];
    char Modelo[20];
    char Dominio[7];
    float Precio;
}Auto;

void anadirAuto(Auto *a, FILE *archivo, char *nombreArchivo);
void listarAutos(Auto a, FILE *archivo, char *nombreArchivo);
void buscarAuto(Auto a, FILE *archivo, char *nombreArchivo);
void vaciarArchivo(FILE *archivo, char *nombreArchivo);

int main(){

    int opcion;
    FILE *archivo = NULL;
    char *nombreArchivo="D:/UCEMA/Programacion1/TP2/archivos/Autos.bin";    
    Auto a;

    do{
        printf("1. Anadir autos nuevos \n");
        printf("2. Listar todos los autos \n");
        printf("3. Buscar x marca o modelo \n");
        printf("4. Vaciar archivo \n");
        printf("5. Salir \n");
        printf("Elija una opcion: ");
        scanf("%d",&opcion);

        switch(opcion){
            case 1:
                anadirAuto(&a,archivo,nombreArchivo);                
                break;  
            case 2:
                listarAutos(a,archivo,nombreArchivo);
                break;
            case 3:
                buscarAuto(a,archivo,nombreArchivo);
                break;
            case 4:
                vaciarArchivo(archivo,nombreArchivo);    
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

void anadirAuto(Auto *a, FILE *archivo, char *nombreArchivo){

    system("cls");
    
    archivo = fopen(nombreArchivo,"ab");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }
    
    printf("Ingrese la marca del auto: ");
    fflush(stdin);
    gets(a->Marca);
    printf("Ingrese el modelo del auto: ");
    fflush(stdin);
    gets(a->Modelo);
    printf("Ingrese el dominio del auto: ");
    fflush(stdin);
    gets(a->Dominio);
    printf("Ingrese el precio del auto: ");
    scanf("%f",&a->Precio);
    
    fwrite(a,sizeof(Auto),1,archivo);
    
    fclose(archivo);
    
    printf("Auto agregado con exito \n");
    system("Pause");
    system("cls");
}

void listarAutos(Auto a, FILE *archivo, char *nombreArchivo){
        
    system("cls");
    
    archivo = fopen(nombreArchivo,"rb");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }

    printf("Listado de Autos: \n");        
    while(!feof(archivo)){
        size_t bytesRead = fread(&a,sizeof(Auto),1,archivo);
        if (bytesRead > 0) {
            printf("\nMarca: %s \n",a.Marca);
            printf("Modelo: %s \n",a.Modelo);
            printf("Dominio: %s \n",a.Dominio);
            printf("Precio: %.2f \n",a.Precio);
        }        
    }
    
    fclose(archivo);
    printf("\n");
    system("Pause");
    system("cls");
}

void buscarAuto(Auto a, FILE *archivo, char *nombreArchivo){
    system("cls");

    archivo = fopen(nombreArchivo, "rb");
    if (archivo == NULL) {
        printf("Error al abrir el archivo");
        system("Pause");
        system("cls");
        return;
    }
    
    char filtro[20];
    int flag = 0;

    printf("Ingrese la marca o el modelo del auto: ");
    fflush(stdin);
    gets(filtro);

    printf("Listado de Autos: \n");
    while(!feof(archivo)){
        size_t bytesRead = fread(&a,sizeof(Auto),1,archivo);
        if (bytesRead > 0) {
            if (strcmp(a.Marca,filtro) == 0) {
                printf("\nMarca: %s \n",a.Marca);
                printf("Modelo: %s \n",a.Modelo);
                printf("Dominio: %s \n",a.Dominio);
                printf("Precio: %.2f \n",a.Precio);
                flag = 1;
            }
            else if (strcmp(a.Modelo,filtro) == 0) {
                printf("\nMarca: %s \n",a.Marca);
                printf("Modelo: %s \n",a.Modelo);
                printf("Dominio: %s \n",a.Dominio);
                printf("Precio: %.2f \n",a.Precio);
                flag = 1;
            }            
        }
    }
    if(flag == 0){
        printf("\nNo se encontro ningun registro \n");
    }

    fclose(archivo);
    printf("\n");
    system("Pause");
    system("cls");
}

void vaciarArchivo(FILE *archivo, char *nombreArchivo){        
    system("cls");
    
    archivo = fopen(nombreArchivo,"w+");
    if(archivo == NULL){
        printf("No existe el archivo \n");
        system("Pause");
        system("cls");
        return;
    }else{
        fclose(archivo);
        printf("Archivo vaciado con exito \n");
        system("Pause");
        system("cls");  
    } 
}
