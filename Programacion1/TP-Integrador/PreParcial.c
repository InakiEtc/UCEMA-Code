#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <malloc.h>
#include <string.h>

typedef struct Producto{
    char Nombre[20];
    char Descripcion[50];
    int Cantidad;
    float Precio;
}Producto;

void Agregar_Producto(Producto *p, FILE *archivo, char *nombreArchivo,FILE *archivoLog, char *nombreLog);
void Listar_Productos(Producto *p, FILE *archivo, char *nombreArchivo);
void Listar_Productos_A_Reponer(Producto *p, FILE *archivo, char *nombreArchivo);
void Buscar_Producto(Producto *p, FILE *archivo, char *nombreArchivo);
void Editar_Producto(Producto *p, FILE *archivo, char *nombreArchivo);

int main(){
    int opcion;
    FILE *archivo = NULL, *archivoLog = NULL;
    char *nombreArchivo = "productos.bin", *nombreLog = "Log.txt";
    Producto *p = NULL;

    do{
        printf("1. Agregar Productos nuevos \n");
        printf("2. Listar todos los productos \n");
        printf("3. Busqueda de Producto \n");
        printf("4. Listar Productos a reponer \n");
        printf("5. Editar un Producto \n");
        printf("6. Salir \n");
        printf("Ingrese una opcion: ");
        scanf("%d",&opcion);

        switch(opcion){
        case 1:
            Agregar_Producto(p,archivo,nombreArchivo,archivoLog,nombreLog);
            break;
        case 2:
            Listar_Productos(p,archivo,nombreArchivo);
            break;
        case 3:
            Buscar_Producto(p,archivo,nombreArchivo);
            break;
        case 4:
            Listar_Productos_A_Reponer(p,archivo,nombreArchivo);
            break;
        case 5:
            Editar_Producto(p,archivo,nombreArchivo);
            break;
        case 6:
            system("cls");
            printf("Saliendo...");
            break;
        default:
            system("cls");
            printf("Ingrese una opcion valida \n");
            system("Pause");
            system("cls");
            break;
        }
    }while(opcion != 6);

    return 0;
}

void Agregar_Producto(Producto *p, FILE *archivo, char *nombreArchivo, FILE *archivoLog, char *nombreLog){

    system("cls");
    archivo=fopen(nombreArchivo,"ab");
    if(archivo == NULL){
        printf("Error al abrir el archivo 'productos'.");
        system("Pause");
        system("cls");
        return;
    }
    archivoLog=fopen(nombreLog,"a");
    if(archivoLog == NULL){
        printf("Error al abrir el archivo 'Log'.");
        system("Pause");
        system("cls");
        return;
    }

    int flag = 0;
    do{
        system("cls");
        p = (Producto *)malloc(sizeof(Producto));

        printf("Ingrese el nombre del producto: ");
        fflush(stdin);
        gets(p->Nombre);
        printf("Ingrese el descripcion del producto: ");
        fflush(stdin);
        gets(p->Descripcion);
        printf("Ingrese el stock del producto: ");
        scanf("%d",&(p->Cantidad));
        printf("Ingrese el precio del producto: ");
        scanf("%f",&(p->Precio));

        fwrite(p,sizeof(Producto),1,archivo);
        fputc("\n",archivo);

        time_t t;
        struct tm *timeinfo;
        time(&t);
        timeinfo = localtime(&t);
        fprintf(archivoLog,"%02d:%02d:%02d. se agrego producto nuevo al archivo Productos.bin \n",timeinfo->tm_hour, timeinfo->tm_min, timeinfo->tm_sec);

        printf("\nProducto cargado con exito\n");
        free(p);

        do{
            printf("\nDesea agregar otro producto? (1 es Si / 0 es No): ");
            scanf("%d",&flag);
        }while(flag != 1 && flag != 0);

    }while(flag == 1);

    fclose(archivo);
    fclose(archivoLog);
    system("cls");
}

void Listar_Productos(Producto *p, FILE *archivo, char *nombreArchivo){

    system("cls");
    archivo=fopen(nombreArchivo,"rb");
    if(archivo == NULL){
        printf("Error al abrir el archivo 'productos'.");
        system("Pause");
        system("cls");
        return;
    }

    int cant = 0;
    fseek(archivo,0,SEEK_END);
    cant=ftell(archivo)/sizeof(Producto);
    rewind(archivo);
    printf("Hay %d Producto/s, aca esta la lista: \n",cant);

    p = (Producto *)malloc(sizeof(Producto));
    while(!feof(archivo)){
        size_t bytesRead = fread(p,sizeof(Producto),1,archivo);
        if(bytesRead > 0){
            printf("\nNombre: %s \n",p->Nombre);
            printf("Descripcion: %s \n",p->Descripcion);
            printf("Cantidad: %d \n",p->Cantidad);
            printf("Precio: %.2f \n",p->Precio);
        }
        fgetc(archivo);
    }
    free(p);
    fclose(archivo);
    printf("\n");
    system("Pause");
    system("cls");
}

void Listar_Productos_A_Reponer(Producto *p, FILE *archivo, char *nombreArchivo){

    system("cls");
    archivo=fopen(nombreArchivo,"rb");
    if(archivo == NULL){
        printf("Error al abrir el archivo 'productos'.");
        system("Pause");
        system("cls");
        return;
    }

    printf("Estos son los productos a reestockear: \n");

    p = (Producto *)malloc(sizeof(Producto));
    while(!feof(archivo)){
        size_t bytesRead = fread(p,sizeof(Producto),1,archivo);
        if(bytesRead > 0 && p->Cantidad <= 2){
            printf("\nNombre: %s \n",p->Nombre);
            printf("Descripcion: %s \n",p->Descripcion);
        }
        fgetc(archivo);
    }
    free(p);
    fclose(archivo);
    printf("\n");
    system("Pause");
    system("cls");
}

void Buscar_Producto(Producto *p, FILE *archivo, char *nombreArchivo){

    system("cls");
    archivo=fopen(nombreArchivo,"rb");
    if(archivo == NULL){
        printf("Error al abrir el archivo 'productos'.");
        system("Pause");
        system("cls");
        return;
    }

    int flag=0;
    char filtro[20];
    printf("Ingrese el nombre del producto a buscar: ");
    fflush(stdin);
    gets(filtro);

    p = (Producto *)malloc(sizeof(Producto));
    while(!feof(archivo)){
        size_t bytesRead = fread(p,sizeof(Producto),1,archivo);
        if(bytesRead > 0 && strcmpi(p->Nombre,filtro) == 0){
            printf("\nNombre: %s \n",p->Nombre);
            printf("Descripcion: %s \n",p->Descripcion);
            printf("Cantidad: %d \n",p->Cantidad);
            printf("Precio: %.2f \n",p->Precio);
            flag=1;
        }
        fgetc(archivo);
    }
    if(flag == 0){
        printf("No se encontro ningun Producto... \n");
    }
    free(p);
    fclose(archivo);
    printf("\n");
    system("Pause");
    system("cls");
}

void Editar_Producto(Producto *p, FILE *archivo, char *nombreArchivo){

    system("cls");
    archivo=fopen(nombreArchivo,"r+b");
    if(archivo == NULL){
        printf("Error al abrir el archivo 'productos'.");
        system("Pause");
        system("cls");
        return;
    }

    int edit;
    char filtro[20];
    printf("Ingrese el nombre del producto a editar: ");
    fflush(stdin);
    gets(filtro);

    p = (Producto *)malloc(sizeof(Producto));
    while(!feof(archivo)){
        size_t bytesRead = fread(p,sizeof(Producto),1,archivo);
        if(bytesRead > 0 && strcmpi(p->Nombre,filtro) == 0){
            printf("Este es el producto: \n");
            printf("\nNombre: %s \n",p->Nombre);
            printf("Descripcion: %s \n",p->Descripcion);
            printf("Cantidad: %d \n",p->Cantidad);
            printf("Precio: %.2f \n",p->Precio);

            do{
                printf("\nQuiere editarlo? (1 es Si / 0 es No): ");
                scanf("%d",&edit);
            }while(edit != 1 && edit != 0);

            if(edit == 1){
                printf("Ingrese el nombre nuevo del producto: ");
                fflush(stdin);
                gets(p->Nombre);
                printf("Ingrese el descripcion nuevo del producto: ");
                fflush(stdin);
                gets(p->Descripcion);
                printf("Ingrese el stock nuevo del producto: ");
                scanf("%d",&(p->Cantidad));
                printf("Ingrese el precio nuevo del producto: ");
                scanf("%f",&(p->Precio));

                int pos=ftell(archivo)-sizeof(Producto);
                fseek(archivo,pos,SEEK_SET);

                fwrite(p,sizeof(Producto),1,archivo);
                printf("\nProducto editado con exito\n");
                free(p);
                fclose(archivo);
                system("Pause");
                system("cls");
                return;

            }else{
                system("cls");
                return;
            }
        }
        fgetc(archivo);
    }
    printf("No se encontro ningun Producto...");

    free(p);
    fclose(archivo);
    printf("\n");
    system("Pause");
    system("cls");
}
