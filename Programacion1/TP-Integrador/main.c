#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
#include <string.h>
#include <time.h>

typedef struct Producto{
    int idProducto;
    char nombreProducto[20];
    float precioProducto;
}Producto;

typedef struct Pedido{
    int idPedido;
    int cantHamburguesas;
    int cantSalchichas;
    float precioPedido;
}Pedido;

typedef Pedido Item;

typedef struct Nodo{
    Item datos;
    struct Nodo *siguiente;
}Nodo;

void inicio(FILE *archivoE, char *nombreArchivoE, FILE *archivoP, char *nombreArchivoP, Nodo **cabeza,int *nroPedido);
void iniciarProductos(Producto *h, Producto *s, FILE *archivoPr, char *nombreArchivoPr);
Nodo *crearNodo(Item *entrada);
void insertarFinal(Nodo **cabeza, Item *entrada);
void agregarPedido(Nodo **cabeza, Producto *h, Producto *s, int nroPedido, FILE *archivoP, char *nombreArchivoP);
//void listarPedidos(Nodo **cabeza); //lista los pedidos desde la lista enlazada

int main(){
    Nodo *cabeza = NULL;
    int op, nroPedido = 1;
    FILE *archivoE = NULL, *archivoP = NULL, *archivoPr = NULL;
    char *nombreArchivoE = "entregados.bin", *nombreArchivoP = "enPreparacion.bin", *nombreArchivoPr = "productos.bin";
    Producto h,s;

    iniciarProductos(&h,&s,archivoPr,nombreArchivoPr);
    do{
        system("cls");
        inicio(archivoE,nombreArchivoE,archivoP,nombreArchivoP,&cabeza,&nroPedido);

        printf("------MENU PRINCIPAL------\n");
        printf("1. AGREGAR PEDIDO\n");
        printf("2. ENTREGAR PEDIDO\n");
        printf("3. IMPRIMIR REPORTES\n");
        printf("4. MODIFICAR PRODUCTOS\n");
        printf("5. SALIR\n");
        printf("\nELIJA UNA OPCION: ");
        scanf("%d",&op);

        switch(op){
            case 1:
                agregarPedido(&cabeza,&h,&s,nroPedido,archivoP,nombreArchivoP);
                nroPedido++;
                break;
            case 2:
                listarPedidos(&cabeza);
                //entregarPedido(&cabeza);
                break;
            case 3:
                //imprimirReportes(&cabeza);
                break;
            case 4:
                //modificarPrecios(&cabeza);
                break; 
            case 5:
                //salir(&cabeza);
                break;
            default:
                system("cls");
                printf("Opcion Invalida. \n");
                system("Pause");
                system("cls");
                break;
        }
    }while( op != 5 );

    return 0;
}

void inicio(FILE *archivoE, char *nombreArchivoE, FILE *archivoP, char *nombreArchivoP, Nodo **cabeza,int *nroPedido){
    
    system("cls");
    int cantE = 0, cantP = 0;

    archivoP = fopen(nombreArchivoP,"rb");
    if(archivoP == NULL){
        archivoP = fopen(nombreArchivoP,"wb");
    }else{
        if(*nroPedido == 1){
            while(!feof(archivoP)){
                Pedido aux;    
                size_t bytesRead = fread(&aux,sizeof(Pedido),1,archivoP);
                if(bytesRead > 0){
                    insertarFinal(cabeza,&aux);
                    (*nroPedido)++;
                }
                fgetc(archivoP);
            }
        }
    }

    fseek(archivoP,0,SEEK_END);
    cantP=ftell(archivoP)/sizeof(Pedido);
    rewind(archivoP);

    archivoE = fopen(nombreArchivoE,"rb");
    if(archivoE == NULL){
        archivoE = fopen(nombreArchivoE,"wb");
    }
    fseek(archivoE,0,SEEK_END);
    cantE=ftell(archivoE)/sizeof(Pedido);
    rewind(archivoE);

    printf("Hay %d Pedido/s entregados: \n",cantE);
    printf("Hay %d Pedido/s en preparacion: \n",cantP);

    fclose(archivoE);
    fclose(archivoP);
    printf("\n");

    return;
}

void iniciarProductos(Producto *h, Producto *s, FILE *archivoPr, char *nombreArchivoPr) {

    archivoPr = fopen(nombreArchivoPr, "rb");
    if (archivoPr == NULL) {
        archivoPr = fopen(nombreArchivoPr, "wb");

        h->idProducto = 101;
        strcpy(h->nombreProducto, "Hamburguesa");
        printf("Ingrese el precio unitario de las hamburguesas: ");
        scanf("%f",&(h->precioProducto));

        s->idProducto = 102;
        strcpy(s->nombreProducto, "Salchicha");
        printf("Ingrese el precio unitario de las salchichas: ");
        scanf("%f",&(s->precioProducto));

        fwrite(h, sizeof(Producto), 1, archivoPr);
        fputc('\n', archivoPr);
        fwrite(s, sizeof(Producto), 1, archivoPr);
        fputc('\n', archivoPr);

        printf("Productos cargados correctamente \n");
        system("Pause");
        system("cls");
    }else{
        fread(h, sizeof(Producto), 1, archivoPr);
        fgetc(archivoPr);
        fread(s, sizeof(Producto), 1, archivoPr);

        printf("Productos cargados correctamente \n");
        system("Pause");
        system("cls");
    } 

    fclose(archivoPr);
    return;
}

Nodo *crearNodo(Item *entrada){
    Nodo *nuevo = NULL;

    nuevo = (Nodo *)calloc(1,sizeof(Nodo));

    if (nuevo == NULL){
        printf("\n\nERROR DE MEMORIA\n\n");
        system("pause");
        return NULL;
    }

    nuevo->datos.idPedido = entrada->idPedido;
    nuevo->datos.cantHamburguesas = entrada->cantHamburguesas;
    nuevo->datos.cantSalchichas = entrada->cantSalchichas;
    nuevo->datos.precioPedido = entrada->precioPedido;
    nuevo->siguiente = NULL;

    return nuevo;
}

void insertarFinal(Nodo **cabeza, Item *entrada){
    Nodo *actual = NULL;

    if (*cabeza == NULL){
        *cabeza = crearNodo(entrada);
    }
    else{
        actual = *cabeza;
        while (actual->siguiente != NULL){
            actual = actual->siguiente;
        }
        actual->siguiente = crearNodo(entrada);
    }

    return;
}

void agregarPedido(Nodo **cabeza, Producto *h, Producto *s, int nroPedido, FILE *archivoP, char *nombreArchivoP){

    Item *entrada = NULL;

    system("cls");
    printf("------AGREGAR PEDIDO------\n");

    entrada = (Item *)calloc(1,sizeof(Item));
    if (entrada == NULL){
        printf("\nERROR DE MEMORIA\n");
        system("pause");
        return;
    }

    entrada->idPedido = nroPedido;
    printf("\nIngrese la cantidad de hamburguesas: ");
    scanf("%d",&(entrada->cantHamburguesas));
    printf("\nIngrese la cantidad de salchichas: ");
    scanf("%d",&(entrada->cantSalchichas));
    entrada->precioPedido = (entrada->cantHamburguesas * h->precioProducto) + (entrada->cantSalchichas * s->precioProducto);

    insertarFinal(cabeza,entrada);
    archivoP=fopen(nombreArchivoP,"ab");
    if(archivoP == NULL){
        printf("Error al abrir el archivo 'enPreparacion'.");
        system("Pause");
        system("cls");
        return;
    }
    fwrite(entrada,sizeof(Pedido),1,archivoP);
    fputc('\n',archivoP);

    fclose(archivoP);
    free(entrada);
    printf("\n\n------AGREGADO CORRECTAMENTE------\n\n");
    system("pause");
    return;
}

/*
void listarPedidos(Nodo **cabeza){
    Nodo *actual = NULL;

    system("cls");
    printf("------VER PEDIDOS------\n");

    if ( *cabeza == NULL ){
        printf("\n\nNO HAY PEDIDOS EN LA LISTA\n\n");
        system("pause");
        return;
    }

    actual = *cabeza;

    while( actual != NULL ){
        printf("\nID: %d\n",actual->datos.idPedido);
        printf("CANTIDAD DE HAMBURGUESAS: %d\n",actual->datos.cantHamburguesas);
        printf("CANTIDAD DE SALCHICHAS: %d\n",actual->datos.cantSalchichas);
        printf("PRECIO: %.2f\n",actual->datos.precioPedido);

        actual = actual->siguiente;
    }

    printf("\n");
    system("pause");
    return;
}*/