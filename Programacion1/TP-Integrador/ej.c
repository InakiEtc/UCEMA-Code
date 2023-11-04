#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
//#include "colores.h"
#include <string.h>
#include <time.h>

typedef struct Producto{
    int id_pedido;
    long fecha;
    char producto[20];
    float precio;
}Producto;

typedef struct Pedido{
    int id_pedido;
    long fecha;
    char producto[20];
    float precio;
}Pedido;

typedef Pedido Item;

typedef struct Nodo{
    Item datos;
    struct Nodo *siguiente;
}Nodo;

Nodo *crearNodo(Item *entrada);
Item *recibirDatos(Item *entrada);
void insertarFinal(Nodo **cabeza, Item *entrada);
void agregarPedido(Nodo **cabeza);
void listarPedidos(Nodo **cabeza);
void eliminarPedido(Nodo **cabeza);
Nodo *inicio(Nodo **cabeza);
void salir(Nodo **cabeza);

int main(){
    Nodo *cabeza = NULL;
    int op;

    srand(time(NULL));
    cabeza = inicio(&cabeza);

    do{
        switch(op)
        {
        case 1:
            agregarPedido(&cabeza);
            break;

        case 2:
            listarPedidos(&cabeza);
            break;

        case 3:
            eliminarPedido(&cabeza);
            break;

        case 4:
            salir(&cabeza);
            break;

        default:
            //red();
            printf("\n\nOPCION INVALIDA\n\n");
            //reset();
            system("pause");
        }

    }while( op != 4 );

    return 0;
}

Nodo *crearNodo(Item *entrada){
    Nodo *nuevo = NULL;

    nuevo = (Nodo *)calloc(1,sizeof(Nodo));

    if ( nuevo == NULL ){
        //red();
        printf("\n\nERROR DE MEMORIA\n\n");
        //reset();
        system("pause");
        return NULL;
    }

    strcpy(nuevo->datos.producto, entrada->producto);
    nuevo->datos.precio = entrada->precio;
    nuevo->datos.fecha = entrada->fecha;
    nuevo->datos.id_pedido = entrada->id_pedido;
    nuevo->siguiente = NULL;

    return nuevo;
}

Item *recibirDatos(Item *entrada){
    printf("\nIngrese \033[1;34mPRODUCTO\033[0m: ");
    fflush(stdin);
    gets(entrada->producto);

    printf("\nIngrese \033[1;34mPRECIO\033[0m: ");
    scanf("%f",&entrada->precio);

    printf("\nIngrese \033[1;34mFECHA\033[0m: ");
    scanf("%ld",&entrada->fecha);

    entrada->id_pedido = rand()%10001;

    return entrada;
}

void insertarFinal(Nodo **cabeza, Item *entrada){
    Nodo *actual = NULL;

    if ( *cabeza == NULL ){
        *cabeza = crearNodo(entrada);
    }
    else{
        actual = *cabeza;
        while ( actual->siguiente != NULL )
        {
            actual = actual->siguiente;
        }

        actual->siguiente = crearNodo(entrada);
    }

    return;
}

void agregarPedido(Nodo **cabeza){
    Item *entrada = NULL;

    system("cls");
    //cyan();
    printf("------AGREGAR PEDIDO------\n");
    //reset();

    entrada = (Item *)calloc(1,sizeof(Item));

    if ( entrada == NULL ){
        //red();
        printf("\n\nERROR DE MEMORIA\n\n");
        //reset();
        system("pause");
        return;
    }

    entrada = recibirDatos(entrada);

    insertarFinal(cabeza,entrada);

    free(entrada);

    //green();
    printf("\n\n------AGREGADO CORRECTAMENTE------\n\n");
    //reset();
    system("pause");
    return;
}

void listarPedidos(Nodo **cabeza){
    Nodo *actual = NULL;

    system("cls");
    //cyan();
    printf("------VER PEDIDOS------\n");
    //reset();

    if ( *cabeza == NULL ){
        //red();
        printf("\n\nNO HAY PEDIDOS EN LA LISTA\n\n");
        //reset();
        system("pause");
        return;
    }

    actual = *cabeza;

    //purple();
    printf("\n%-5s   %-20s   %-8s   %s\n",
           "ID",
           "PRODUCTO",
           "PRECIO",
           "FECHA");
    //reset();

    while( actual != NULL ){
        printf("\n%-5d   %-20s   $%5.2f   %ld\n",
           actual->datos.id_pedido,
           actual->datos.producto,
           actual->datos.precio,
           actual->datos.fecha);

        actual = actual->siguiente;
    }

    printf("\n");
    system("pause");
    return;
}

void eliminarPedido(Nodo **cabeza){
    Nodo *actual = NULL , *siguiente = NULL;
    int encuentro = 0, idBuscado;

    system("cls");
    //cyan();
    printf("------ELIMINAR PEDIDO------\n");
    //reset();

    if ( *cabeza == NULL ){
        //red();
        printf("\n\nNO HAY PEDIDOS EN LA LISTA\n\n");
        //reset();
        system("pause");
        return;
    }

    printf("\nIngrese \033[1;34mID\033[0m: ");
    scanf("%d",&idBuscado);

    actual = *cabeza;

    while( actual != NULL ){
        siguiente = actual->siguiente;

        if ( actual == *cabeza && actual->datos.id_pedido == idBuscado ){
            encuentro = 1;
            *cabeza = actual->siguiente;
            free(actual);
            break;
        }

        if ( siguiente != NULL && siguiente->datos.id_pedido == idBuscado ){
            if ( siguiente->siguiente != NULL ){
                actual->siguiente = siguiente->siguiente;
            }
            else{
                actual->siguiente = NULL;
            }

            encuentro = 1;
            free(siguiente);
            break;
        }
        else{
            actual = actual->siguiente;
        }
    }

    if ( encuentro == 1 ){
        //green();
        printf("\n\n------ELIMINADO CORRECTAMENTE------\n\n");
    }
    else{
        //red();
        printf("\n\nNO HUBO COINCIDENCIAS\n\n");
    }
    //reset();

    system("pause");
    return;
}

Nodo *inicio(Nodo **cabeza){
    char *filename = "pedidos.bin";
    FILE *pFile = NULL;
    Item *entrada = NULL;
    Nodo *actual = NULL;

    entrada = (Item *)calloc(1,sizeof(Item));

    if ( entrada == NULL ){
        //red();
        printf("\n\nERROR DE MEMORIA\n\n");
        //reset();
        system("pause");
        return NULL;
    }

    pFile = fopen(filename,"rb");

    if ( pFile != NULL ){
        while ( fread(entrada,sizeof(Item),1,pFile) == 1 ){
            if ( *cabeza == NULL ){
                actual = crearNodo(entrada);
                *cabeza = actual;
            }
            else{
                actual->siguiente = crearNodo(entrada);
                actual = actual->siguiente;
            }
            fgetc(pFile);
        }
    }

    fclose(pFile);
    return *cabeza;
}

void salir(Nodo **cabeza){
    char *filename = "pedidos.bin";
    FILE *pFile = NULL;
    Nodo *actual = NULL , *auxiliar = NULL;
    Item *entrada = NULL;

    //purple();
    printf("\n\n------SALIR------\n");
    //reset();

    if ( *cabeza == NULL ){
        return;
    }

    entrada = (Item *)calloc(1,sizeof(Item));

    if ( entrada == NULL ){
        //red();
        printf("\n\nERROR DE MEMORIA\n\n");
        //reset();
        system("pause");
        return;
    }

    pFile = fopen(filename,"wb");

    if ( pFile == NULL ){
        //red();
        printf("\n\nERROR AL ABRIR ARCHIVO\n\n");
        //reset();
        system("pause");
    }

    actual = *cabeza;

    while ( actual != NULL ){
        fwrite(&actual->datos,sizeof(Item),1,pFile);
        fputc('\n',pFile);
        auxiliar = actual;
        actual = actual->siguiente;
        free(auxiliar);
    }
    fclose(pFile);
    return;
}


