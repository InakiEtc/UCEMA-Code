#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct Amigo{    
    char Nombre[20];
    char Apellido[20];
    char Telefono[10];
}Amigo;

void ingresarAmigo(Amigo *a, FILE *archivo, char *nombreArchivo);
void listarAmigos(Amigo a, FILE *archivo, char *nombreArchivo);
void buscarAmigo(Amigo a, FILE *archivo, char *nombreArchivo);
void cantidadAmigos(Amigo a, FILE *archivo, char *nombreArchivo);
void vaciarArchivo(FILE *archivo,char *nombreArchivo);
void eliminarArchivo(char *nombreArchivo);

int main(){

    int opcion;
    FILE *archivo = NULL;
    char *nombreArchivo="D:/UCEMA/Programacion1/TP2/archivos/Agenda.bin";    
    Amigo a;

    do{
        printf("1. Ingresar datos de Amigo \n");
        printf("2. Listar todos los amigos \n");
        printf("3. Buscar x Nombre \n");
        printf("4. Informar cantidad de Amigos \n");
        printf("5. Vaciar archivo \n");
        printf("6. Eliminar archivo \n");
        printf("7. Salir \n");
        printf("Elija una opcion: ");
        scanf("%d",&opcion);

        switch(opcion){
            case 1:
                ingresarAmigo(&a,archivo,nombreArchivo);                
                break;  
            case 2:
                listarAmigos(a,archivo,nombreArchivo);
                break;
            case 3:
                buscarAmigo(a,archivo,nombreArchivo);
                break;
            case 4:
                cantidadAmigos(a,archivo,nombreArchivo);    
                break;
            case 5:
                vaciarArchivo(archivo,nombreArchivo);    
                break;
            case 6:
                eliminarArchivo(nombreArchivo);   
                break;
            case 7:
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
    }while (opcion != 7); 

    return 0;
}

void ingresarAmigo(Amigo *a, FILE *archivo, char *nombreArchivo){
    system("cls");

    archivo = fopen(nombreArchivo,"ab");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }
    
    printf("Ingrese el Nombre: ");
    fflush(stdin);
    gets(a->Nombre);
    
    printf("Ingrese el Apellido: ");
    fflush(stdin);
    gets(a->Apellido);

    printf("Ingrese el numero de Telefono: ");
    fflush(stdin);
    gets(a->Telefono);
    
    fwrite(a,sizeof(Amigo),1,archivo);
    fclose(archivo);

    printf("Amigo ingresado con exito \n");
    printf("\n");
    system("Pause");
    system("cls");  

}

void listarAmigos(Amigo a, FILE *archivo, char *nombreArchivo){
    system("cls");

    archivo = fopen(nombreArchivo,"rb");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }
    
    printf("Lista de Amigos: \n"); 
    while(!feof(archivo)){
        size_t bytesRead = fread(&a,sizeof(Amigo),1,archivo);
        if (bytesRead > 0) {
            printf("\nNombre: %s \n",a.Nombre);
            printf("Apellido: %s \n",a.Apellido);
            printf("Telefono: %s \n",a.Telefono);           
        }
    }
    fclose(archivo);
    printf("\n");
    system("Pause");
    system("cls");  

}

void buscarAmigo(Amigo a, FILE *archivo, char *nombreArchivo){
    system("cls");

    archivo = fopen(nombreArchivo,"rb");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }
    
    char nomaux[20];

    printf("Ingrese el Nombre del amigo a buscar: ");
    fflush(stdin);
    gets(nomaux);
    
    while(!feof(archivo)){
        size_t bytesRead = fread(&a,sizeof(Amigo),1,archivo);
        if (bytesRead > 0) {
            if(strcmp(a.Nombre,nomaux) == 0){
                printf("\nNombre: %s \n",a.Nombre);
                printf("Apellido: %s \n",a.Apellido);
                printf("Telefono: %s \n",a.Telefono); 
            }           
        }
    }
    fclose(archivo);
    printf("\n");
    system("Pause");
    system("cls");
}

void cantidadAmigos(Amigo a, FILE *archivo, char *nombreArchivo){
    system("cls");

    archivo = fopen(nombreArchivo,"rb");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }
    
    int cont = 0;

    while(!feof(archivo)){
        size_t bytesRead = fread(&a,sizeof(Amigo),1,archivo);
        if (bytesRead > 0) {
            cont++;           
        }
    }
    fclose(archivo);
    printf("La cantidad de amigos es: %d \n",cont);
    printf("\n");
    system("Pause");
    system("cls");
}

void vaciarArchivo(FILE *archivo,char *nombreArchivo){        
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

void eliminarArchivo(char *nombreArchivo){
    system("cls");
    int borrar;
    borrar = remove(nombreArchivo);
    if (borrar == 0){
        printf("Archivo borrado \n");
        system("Pause");
        system("cls"); 
    }else{
        printf("No se pudo borrar el archivo \n");
        system("Pause");
        system("cls");
    }
}
