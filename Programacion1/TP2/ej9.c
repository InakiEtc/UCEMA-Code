#include <stdio.h>
#include <stdlib.h>

typedef struct Producto{
    int codigo;
    char nombre[20];
    float precio;
}Producto;

void cargarProducto(Producto *p, FILE *archivo, char *nombreArchivo);
void listarProductos(Producto *p, FILE *archivo, char *nombreArchivo);

int main(){

    Producto *p = NULL;
    int opcion;
    FILE *archivo = NULL;
    char *nombreArchivo="D:/UCEMA/Programacion1/TP2/archivos/Productos.bin";

    do{
        printf("1. Cargar producto \n");
        printf("2. Listar productos \n");
        printf("3. Salir \n");
        printf("Elija una opcion: ");
        scanf("%d",&opcion);

        switch(opcion){
            case 1:
                cargarProducto(p,archivo,nombreArchivo);             
                break;  
            case 2:
                listarProductos(p,archivo,nombreArchivo);
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

    }while(opcion != 3);  

    return 0;
}

void cargarProducto(Producto *p, FILE *archivo, char *nombreArchivo){
    system("cls");

    p = (Producto *)malloc(sizeof(Producto));

    printf("Ingrese el codigo del producto: ");
    scanf("%d", &(p->codigo));    
    printf("Ingrese el nombre del producto: ");
    fflush(stdin);
    gets(p->nombre);
    printf("Ingrese el precio del producto: ");
    scanf("%f",&(p->precio));

    archivo = fopen(nombreArchivo,"ab");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }

    fwrite(p,sizeof(Producto),1,archivo);
    fputc('\n',archivo);
    fclose(archivo);
    free(p);

    printf("Producto cargado correctamente \n");
    system("Pause");
    system("cls");
}

void listarProductos(Producto *p, FILE *archivo, char *nombreArchivo){
    system("cls");

    archivo = fopen(nombreArchivo,"rb");
    if(archivo == NULL){
        printf("Error al abrir el archivo \n");
        system("Pause");
        system("cls");
        return;
    }

    p = (Producto *)malloc(sizeof(Producto));

    printf("Lista de Productos: \n");   
    while (!feof(archivo)){
        size_t bytesRead = fread(p,sizeof(Producto),1,archivo);
        if (bytesRead > 0) {
            printf("\nCodigo: %d \n",p->codigo);
            printf("Nombre: %s \n",p->nombre);
            printf("Precio: %.2f \n",p->precio);            
        }
        fgetc(archivo);
    }

    fclose(archivo);
    free(p); 
    system("Pause");
    system("cls");
}