#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct Producto{
    char Tipo[20];
    char Marca[20];
    float Tamano;
    float Precio;
    int Stock;
}Producto;

void agregarProductos(Producto *p, FILE *archivo, char *nombreArchivo);
void listarProductos(Producto p, FILE *archivo, char *nombreArchivo);
void buscarProductos(Producto p, FILE *archivo, char *nombreArchivo);

int main(){

    int opcion;
    FILE *archivo = NULL;
    char *nombreArchivo="D:/UCEMA/Programacion1/TP2/archivos/Products.txt";
    Producto p;

    do{
        printf("1. Agregar productos \n");
        printf("2. Listar productos \n");
        printf("3. Buscar productos \n");
        printf("4. Salir \n");
        printf("Elija una opcion: ");
        scanf("%d",&opcion);

        switch(opcion){
            case 1:
                agregarProductos(&p,archivo,nombreArchivo);                
                break;  
            case 2:
                listarProductos(p,archivo,nombreArchivo);
                break;
            case 3:
                buscarProductos(p,archivo,nombreArchivo);
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
    }while (opcion != 4);   
    return 0;
}

void agregarProductos(Producto *p, FILE *archivo, char *nombreArchivo){
    
    system("cls");
    
    archivo=fopen(nombreArchivo,"ab");
    if(archivo==NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }

    printf("Ingrese el tipo del Producto: ");
    fflush(stdin);
    gets(p->Tipo);

    printf("Ingrese la Marca del Producto: ");
    fflush(stdin);
    gets(p->Marca);
    
    printf("Ingrese el Tamano del Producto: ");
    scanf("%f", &p->Tamano);

    printf("Ingrese el Precio del Producto: ");
    scanf("%f", &p->Precio);

    printf("Ingrese el Stock del Producto: ");
    scanf("%d", &p->Stock);

    fwrite(p, sizeof(Producto), 1, archivo);

    fclose(archivo);
    system("cls");
}

void listarProductos(Producto p, FILE *archivo, char *nombreArchivo){
    system("cls");
    archivo = fopen(nombreArchivo, "rb");
    if (archivo == NULL) {
        printf("Error al abrir el archivo");
        system("Pause");
        system("cls");
        return;
    }

    printf("Listado de Productos: \n");
    while(!feof(archivo)){         
        size_t bytesRead = fread(&p, sizeof(Producto), 1, archivo);
        if (bytesRead > 0) {
            printf("\nTipo: %s\n", p.Tipo);
            printf("Marca: %s\n", p.Marca);
            printf("Tamano: %.2f\n", p.Tamano);
            printf("Precio: %.2f\n", p.Precio);
            printf("Stock: %d\n", p.Stock); 
        }                              
    }  

    fclose(archivo);
    system("Pause");
    system("cls");
}

void buscarProductos(Producto p, FILE *archivo, char *nombreArchivo){
    system("cls");
    archivo = fopen(nombreArchivo, "rb");
    if (archivo == NULL) {
        printf("Error al abrir el archivo");
        system("Pause");
        system("cls");
        return;
    }

    char marca[20];
    printf("Ingrese la marca del producto a buscar: ");
    fflush(stdin);
    gets(marca);

    while(!feof(archivo)){         
        size_t bytesRead = fread(&p, sizeof(Producto), 1, archivo);
        if (bytesRead > 0) {
            if(strcmp(p.Marca,marca)==0){
                printf("\nTipo: %s\n", p.Tipo);
                printf("Marca: %s\n", p.Marca);
                printf("Tamano: %.2f\n", p.Tamano);
                printf("Precio: %.2f\n", p.Precio);
                printf("Stock: %d\n", p.Stock); 
            }            
        }                              
    }  

    fclose(archivo);
    system("Pause");
    system("cls");
}