#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>
#include <string.h>
#include <time.h>

// creo la estructura de productos
typedef struct{
    int idProducto;
    char nombreProducto[20];
    float precioProducto;
}Producto;

// creo la estructura de pedidos
typedef struct{
    int idPedido;
    int cantHamburguesas;
    int cantSalchichas;
    float precioPedido;
}Pedido;


typedef Pedido Item;

// creo la estructura nodo
typedef struct Nodo{
    Item datos;
    struct Nodo *siguiente;
}Nodo;

// firmas de las funciones
void iniciar(char *nombreArchivoPrep, Nodo **cabeza, int *nroPedidos, int *idMaximo);
void iniciarProductos(Producto *h, Producto *s, char *nombreArchivoProd, int modi);
void salir(int totalProductosVendidos, float totalFacturado, char *nombreArchivoTotal);
void reescribirPreparacion(Nodo **cabeza);

Nodo *crearNodo(Item *entrada);
void insertarFinal(Nodo **cabeza, Item *entrada);

void agregarPedido(Nodo **cabeza, Producto *h, Producto *s, int *nroPedidos, char *nombreArchivoPrep, int *idMaximo);
void entregarPedido(Nodo **cabeza, char *nombreArchivoEnt, int *nroPedidos, float *totalFacturado, int *totalProductosVendidos);
void reportes(Nodo **cabeza, char *nombreArchivoEnt);
void listarEnPreparacion(Nodo **cabeza);
void listarEntregados(char *nombreArchivoEnt);

int main(){
    // creo las variables
    // puntero doble para guardar el nodo cabeza
    Nodo *cabeza = NULL;

    // enteros para guardar la opcion del menu principal, la cantidad de pedidos que estan en preparacion (nroPedidos)
    // y el id maximo. Este ultimo es para no repetir los ids.
    int op, nroPedidos = 0, idMaximo = 100;

    // nombres de los archivos
    char *nombreArchivoEnt = "entregados.bin", *nombreArchivoPrep = "enPreparacion.bin", *nombreArchivoProd = "productos.bin", *nombreArchivoTotal = "log.txt";

    // estructuras de productos para guardar los precios de las hamburguesas y de las salchichas.
    Producto h,s;

    // entero para guardar la cantidad de productos vendidos durante el lapso del programa
    int totalProductosVendidos = 0;

    // float para el total facturado durante el lapso del programa
    float totalFacturado = 0.0;

    // inicializamos los productos y la lista de pedidos en preparacion
    iniciarProductos(&h,&s,nombreArchivoProd,0);
    iniciar(nombreArchivoPrep,&cabeza,&nroPedidos,&idMaximo);

    // menu de opciones
    do{
        system("cls");
        printf("Hay %d PEDIDOS EN PREPARACION.\n\n",nroPedidos);
        printf("------MENU PRINCIPAL------\n");
        printf("\t1. AGREGAR PEDIDO\n");
        printf("\t2. ENTREGAR PEDIDO\n");
        printf("\t3. IMPRIMIR REPORTES\n");
        printf("\t4. MODIFICAR PRODUCTOS\n");
        printf("\t5. SALIR\n");
        printf("\nIngrese OPCION: ");
        scanf("%d",&op);

        switch(op){
            case 1:
                agregarPedido(&cabeza, &h, &s, &nroPedidos, nombreArchivoPrep, &idMaximo);
                break;
            case 2:
                entregarPedido(&cabeza, nombreArchivoEnt, &nroPedidos, &totalFacturado, &totalProductosVendidos);
                break;
            case 3:
                reportes(&cabeza, nombreArchivoEnt);
                break;
            case 4:
                iniciarProductos(&h,&s,nombreArchivoProd,1);
                break;
            case 5:
                salir(totalProductosVendidos,totalFacturado,nombreArchivoTotal);
                break;
            default:
                printf("\n\nERROR. OPCION INVALIDA\n\n");
                system("Pause");
                break;
        }
    }while( op != 5 );

    return 0;
}

void iniciar(char *nombreArchivoPrep, Nodo **cabeza, int *nroPedido, int *idMaximo){
    /* La funcion es para inicializar la lista de pedidos en preparacion.
    Se ejecuta al inicio del programa.
    Espera recibir el nombre del archivo de pedidos en preparacion, el puntero doble al nodo cabeza,
    un entero que tiene la cantidad de pedidos en preparacion y un entero al id maximo.
    No retorna valores.
    */

    // creo un puntero a file para abrir el archivo en preparacion
    FILE *archivoPrep = NULL;

    // archivo en preparacion
    archivoPrep = fopen(nombreArchivoPrep,"rb");

    // si el archivo productos existe, entonces leo lo que hay adentro.
    if(archivoPrep != NULL){
        while(!feof(archivoPrep)){// leo pedido por pedido y lo guardo en la estructura 
            Pedido pedidoAux; //creo pedido auxiliar para guardar los datos    
            size_t bytesRead = fread(&pedidoAux,sizeof(Pedido),1,archivoPrep);
            if(bytesRead > 0){
                // agrego el pedido al final de la lista
                insertarFinal(cabeza,&pedidoAux);
                // incremento el nroPedidos y guardo el id maximo
                (*nroPedido)++;
                *idMaximo = pedidoAux.idPedido;
            }
            // tomo el \n
            fgetc(archivoPrep);
        }
    }

    // si el archivo no existe, no pasa nada. quiere decir que se ejecuto el
    // programa por primera vez o que no hay pedidos en preparacion.

    // cierro archivo
    fclose(archivoPrep);
    return;
}

void iniciarProductos(Producto *h, Producto *s, char *nombreArchivoProd, int modi){
    /* la funcion es para inicializar la informacion de los productos.
    espera recibir dos punteros a las estructuras de productos y el nombre del archivo productos.
    no retorna valores. se pasa parametro modi para saber si se esta modificando o no los productos, si es 1 entonces se esta modificando.
    si es 0 entonces se esta inicializando.
    */

    // creo puntero a file para el leer archivo productos
    FILE *archivoProd = NULL;

    // abro el archivo
    archivoProd = fopen(nombreArchivoProd, "rb");
    if (archivoProd == NULL || modi) {// quiere decir que no tenemos informacion de los productos, entonces tenemos que pedir los datos o que se quiere modificar
        system("cls");
        if(modi){ //muestra mensaje correspondiente a si se esta modificando o inicializando
            printf("------MODIFICANDO PRODUCTOS------\n\n");
        }else{
            printf("------INICIALIZANDO PRODUCTOS------\n\n");
        }

        // pido los datos de las hamburguesas
        h->idProducto = 101;
        strcpy(h->nombreProducto, "Hamburguesa");
        printf("Ingrese PRECIO UNITARIO de las HAMBURGUESAS: ");
        scanf("%f",&(h->precioProducto));
        while( h->precioProducto < 0.0 ){ // valido que sea mayor a cero
            printf("\nERROR. PRECIO INVALIDO\n");
            printf("\nIngrese PRECIO UNITARIO de las HAMBURGUESAS: ");
            scanf("%f",&(h->precioProducto));
        }

        // pido los datos de las salchichas
        s->idProducto = 102;
        strcpy(s->nombreProducto, "Salchicha");
        printf("\n\nIngrese PRECIO UNITARIO de las SALCHICHAS: ");
        scanf("%f",&(s->precioProducto));
        while( s->precioProducto < 0.0 ){// valido que sea mayor a cero
            printf("\nERROR. PRECIO INVALIDO\n");
            printf("\nIngrese PRECIO UNITARIO de las HAMBURGUESAS: ");
            scanf("%f",&(s->precioProducto));
        }

        archivoProd = fopen(nombreArchivoProd, "wb");// abro el archivo productos para guardar los datos
        if(archivoProd == NULL){
            printf("\n\nERROR AL CREAR ARCHIVO PRODUCTOS\n\n");
            system("pause");
            return;
        }
        // guardo las estructuras en el archivo
        fwrite(h, sizeof(Producto), 1, archivoProd);
        fputc('\n', archivoProd);
        fwrite(s, sizeof(Producto), 1, archivoProd);
        fputc('\n', archivoProd);  
    }
    else{// quiere decir que el archivo ya tiene las estructuras guardadas
        // leo los datos en las estructuras
        fread(h, sizeof(Producto), 1, archivoProd);
        fgetc(archivoProd);
        fread(s, sizeof(Producto), 1, archivoProd);
    }

    fclose(archivoProd);
    if(modi){//muestra mensaje correspondiente a si se modifico o se inicializo
        printf("\n\n------PRODUCTOS MODIFICADOS CORRECTAMENTE------\n\n");
    }else{
        printf("\n\n------PRODUCTOS CARGADOS CORRECTAMENTE------\n\n");
    }
    system("Pause");
    return;
}

void reescribirPreparacion(Nodo **cabeza){
    /* la funcion se encarga de reescribir el archivo en preparacion cada vez que se entrega un pedido.
    espera recibir el puntero doble al nodo cabeza y no retorna valores.
    */

    // creo puntero a file para el archivo en preparacion.
    FILE *archivoPrep = NULL;

    // creo puntero a nodo actual para recorrer la lista.
    Nodo *actual = NULL;

    // abro el archivo en preparacion
    archivoPrep = fopen("enPreparacion.bin","wb");

    // empezamos por la cabeza
    actual = *cabeza;

    while( actual != NULL ){ // recorremos la lista hasta encontrar el ultimo nodo
        // escribimos los datos del nodo en el archivo
        fwrite(&actual->datos,sizeof(Pedido),1,archivoPrep);
        fputc('\n',archivoPrep);

        actual = actual->siguiente; // siguiente nodo
    }

    fclose(archivoPrep);
    return;

}

Nodo *crearNodo(Item *entrada){
    /*
    la funcion se encarga de crear un nodo en la memoria dinamica con los datos
    que espera recibir como parametro de entrada en una estructura item.
    retorna el puntero al nodo creado.
    */

    // creo puntero a nodo nuevo.
    Nodo *nuevo = NULL;

    // reservamos memoria dinamica para el nodo.
    nuevo = (Nodo *)calloc(1,sizeof(Nodo));

    // valido que haya memoria
    if(nuevo == NULL){
        printf("\n\nERROR DE MEMORIA\n\n");
        system("pause");
        return NULL;
    }

    // copio los datos recibidos como entrada en el nodo nuevo
    nuevo->datos.idPedido = entrada->idPedido;
    nuevo->datos.cantHamburguesas = entrada->cantHamburguesas;
    nuevo->datos.cantSalchichas = entrada->cantSalchichas;
    nuevo->datos.precioPedido = entrada->precioPedido;
    nuevo->siguiente = NULL;

    return nuevo;
}

void insertarFinal(Nodo **cabeza, Item *entrada){
    /*
    la funcion se encarga de insertar un nodo al final de la lista.
    espera recibir como parametros de entrada el puntero doble al nodo cabeza
    y un puntero a una estructura item con los datos de un pedido.
    no retorna valores.
    */

    // creo puntero a nodo para recorrer la lista.
    Nodo *actual = NULL;

    if(*cabeza == NULL){
        // si el nodo cabeza es null, entonces hay que crear un nodo e insertarlo en la cabeza.
        *cabeza = crearNodo(entrada); // llamada al la funcion crear nodo y lo pongo en cabeza
    }
    else{
        // si el nodo cabeza no es null, entonces hay que encontrar el ultimo nodo
        actual = *cabeza;
        // recorro la lista hasta encontrarlo
        while (actual->siguiente != NULL){
            actual = actual->siguiente;
        }
        actual->siguiente = crearNodo(entrada); // llamada a la funcion crear nodo y lo pongo en el final.
    }

    return;
}

void agregarPedido(Nodo **cabeza, Producto *h, Producto *s, int *nroPedidos, char *nombreArchivoPrep, int *idMaximo){
    /*
    la funcion agregar pedido se encarga de recibir los datos de un pedido, calcular el precio del pedido
    y despues llama a la funcion insertarFinal para agregar el pedido a la lista. luego actualiza el archivo en preparacion.

    espera recibir como parametros de entrada el puntero doble al nodo cabeza, los punteros a las estructuras de productos, el
    puntero a la cantidad de pedidos en preparacion, el nombre del archivo en preparacion y el id maximo.

    no devuelve valores.
    */

    // creo estructura item para guardar datos del pedido
    Item *entrada = NULL;

    // creo puntero a file para el archivo en preparacion
    FILE *archivoPrep = NULL;

    system("cls");
    printf("------AGREGAR PEDIDO------\n");

    // pido memoria para el pedido
    entrada = (Item *)calloc(1,sizeof(Item));

    // valido que haya memoria
    if (entrada == NULL){
        printf("\nERROR DE MEMORIA\n");
        system("pause");
        return;
    }

    // incremento el id maximo y lo asigno al id del pedido a agregar. despues lo imprimo
    (*idMaximo)++;
    entrada->idPedido = *idMaximo;
    printf("\nID PEDIDO: %d\n",entrada->idPedido);

    // pido que ingrese la cantidad de hamburguesas
    printf("\nIngrese CANTIDAD de HAMBURGUESAS: ");
    scanf("%d",&(entrada->cantHamburguesas));
    while ( entrada->cantHamburguesas < 0 ){ //valido que la cantidad sea mayor 0
        printf("\nERROR. CANTIDAD INVALIDA. Reingrese CANTIDAD de HAMBURGUESAS: ");
        scanf("%d",&(entrada->cantHamburguesas));
    }

    // pido que ingrese la cantidad de salchichas
    printf("\nIngrese CANTIDAD de SALCHICHAS: ");
    scanf("%d",&(entrada->cantSalchichas));
    while ( entrada->cantSalchichas < 0 ){//valido que la cantidad sea mayor 0
        printf("\nERROR. CANTIDAD INVALIDA. Reingrese CANTIDAD de SALCHICHAS: ");
        scanf("%d",&(entrada->cantSalchichas));
    }

    // calculo el precio y lo asigno en la entrada
    entrada->precioPedido = (entrada->cantHamburguesas * h->precioProducto) + (entrada->cantSalchichas * s->precioProducto);

    // lo imprimo
    printf("\nPRECIO del pedido: $%.2f\n",entrada->precioPedido);

    // inserto a la lista
    insertarFinal(cabeza,entrada);

    // abro el archivo en preparacion
    archivoPrep = fopen(nombreArchivoPrep,"ab");
    // valido que se haya abierto el archivo
    if(archivoPrep == NULL){
        printf("ERROR AL ABRIR ARCHIVO 'enPreparacion'.");
        system("Pause");
        return;
    }

    // guardo los datos en el archivo
    fwrite(entrada,sizeof(Pedido),1,archivoPrep);
    fputc('\n',archivoPrep);

    // cierro archivo y libero memoria de entrada
    fclose(archivoPrep);
    free(entrada);

    // incremento nro de pedidos en preparacion
    (*nroPedidos)++;
    printf("\n\n------AGREGADO CORRECTAMENTE------\n\n");
    system("pause");
    return;
}

void entregarPedido(Nodo **cabeza, char *nombreArchivoEnt, int *nroPedidos,float *totalFacturado, int *totalProductosVendidos)
{
    /*
    la funcion entregar pedido se encarga de pedir al usuario un id y entregar el pedido correspondiente eliminandolo de
    la lista.
    espera recibir como parametros de entrada el puntero doble al nodo cabeza, el nombre del archivo entregados, el puntero a la
    cantidad de pedidos en preparacion, el puntero al tota facturado y el puntero al total de productos vendidos.
    no retorna valores.
    */

    // creo entero para el id de entrada y para el flag encuentro
    int entrada, encuentro = 0;

    // creo punteros a nodo actual y auxiliar para recorrer la lista.
    Nodo *actual = NULL , *auxiliar = NULL;

    // creo punteros a file de entregados y en preparacion.
    FILE *archivoEnt = NULL;

    system("cls");
    printf("------ENTREGAR PEDIDO------\n");

    // primero valido que haya pedidos en preparacion
    if ( *cabeza == NULL )
    {
        printf("\n\nNO HAY PEDIDOS EN PREPARACION\n\n");
        system("pause");
        return;
    }

    // pido que ingrese el id para buscar
    printf("\nIngrese ID PEDIDO: ");
    scanf("%d",&entrada);

    // recorro la lista
    actual = *cabeza;

    while ( actual != NULL )
    {
        auxiliar = actual->siguiente; // uso el puntero auxiliar para guardar el siguiente nodo

        if ( actual == *cabeza && actual->datos.idPedido == entrada ) // caso en el que el pedido buscado esta en la cabeza
        {
            // guardo la cabeza en auxiliar, reescribo la cabeza y pongo encuentro en 1
            auxiliar = *cabeza;
            *cabeza = actual->siguiente;
            encuentro = 1;
            break;
        }

        else if ( auxiliar != NULL && auxiliar->datos.idPedido == entrada )
        {
            if ( auxiliar->siguiente != NULL ) // caso en que el pedido buscado esta en el medio de la lista
            {
                actual->siguiente = auxiliar->siguiente;
            }
            else // caso en que esta en el final de la lista
            {
                actual->siguiente = NULL;
            }

            encuentro = 1;
            break;
        }
        else // si no coincide la entrada con el id, avanzo al siguiente nodo
        {
            actual = actual->siguiente;
        }
    }

    if ( encuentro == 1 ) // si encontre el id, guardo el pedido en el archivo entregados
    {
        archivoEnt = fopen(nombreArchivoEnt,"a+b");
        fwrite(&auxiliar->datos,sizeof(Pedido),1,archivoEnt);
        fputc('\n',archivoEnt);
        fclose(archivoEnt);

        printf("\n\n------PEDIDO %d ENTREGADO CORRECTAMENTE------\n\n",auxiliar->datos.idPedido);

        // reescribir archivo preparacion
        reescribirPreparacion(cabeza);

        // resto el nroPedidos en preparacion
        *nroPedidos = *nroPedidos - 1;

        // incremento el total de productos vendidos
        *totalProductosVendidos = (*totalProductosVendidos) + auxiliar->datos.cantHamburguesas + auxiliar->datos.cantSalchichas;

        // incremento el total facturado
        *totalFacturado = *totalFacturado + auxiliar->datos.precioPedido;
        free(auxiliar); // libero la memoria
    }
    else // si no lo encontre mando mensaje de error
    {
        printf("\n\nNO HUBO COINCIDENCIAS\n\n");
    }

    system("pause");
    return;
}

void reportes(Nodo **cabeza, char *nombreArchivoEnt)
{
    // la funcion ofrece el menu secundario para mostrar los reportes

    // creo un entero para guardar la opcion que ingresa el usuario
    int sOp;
    system("cls");
    printf("------MOSTRAR REPORTES------\n");

    // menu de opciones
    do
    {
        system("cls");
        printf("------MENU REPORTES------\n");
        printf("\t1. VER PEDIDOS EN PREPARACION\n");
        printf("\t2. VER PEDIDOS ENTREGADOS\n");
        printf("\t3. VOLVER AL MENNU PRINCIPAL\n");
        printf("\nIngrese OPCION: ");
        scanf("%d",&sOp);

        switch(sOp)
        {
        case 1:
            listarEnPreparacion(cabeza);
            break;

        case 2:
            listarEntregados(nombreArchivoEnt);
            break;

        case 3:
            printf("\n\n------VOLVER AL MENU PRINCIPAL------\n\n");
            system("pause");
            break;

        default:
            printf("\n\nERROR. OPCION INVALIDA\n\n");
            system("pause");
        }

    }while(sOp != 3);

    return;
}

void listarEnPreparacion(Nodo **cabeza)
{
    // la funcion lista los pedidos en preparacion
    // espera recibir el puntero doble al nodo cabeza y no retorna valores

    // creo un nodo para recorrer la lista
    Nodo *actual = NULL;

    system("cls");
    printf("------VER PEDIDOS EN PREPARACION------\n");

    // valido que haya pedidos en la lista
    if ( *cabeza == NULL )
    {
        printf("\n\nNO HAY PEDIDOS EN LA LISTA\n\n");
        system("pause");
        return;
    }

    // imprimo los encabezados
    printf("\n%-5s   %-20s   %-20s   %s\n",
           "ID",
           "#HAMBURGUESAS",
           "#SALCHICHAS",
           "PRECIO");

    // recorro la lista e imprimo los datos
    actual = *cabeza;

    while( actual != NULL ){

        printf("\n%-5d   %-20d   %-20d   $%.2f\n",
           actual->datos.idPedido,
           actual->datos.cantHamburguesas,
           actual->datos.cantSalchichas,
           actual->datos.precioPedido);

        actual = actual->siguiente;
    }

    printf("\n");
    system("pause");
    return;
}

void listarEntregados(char *nombreArchivoEnt)
{
    // la funcion imprime los pedidos que estan en el archivo entregados

    FILE *archivoEnt = NULL;
    Pedido pedidoAux; // creo pedido para leer el archivo

    system("cls");
    printf("------VER PEDIDOS ENTREGADOS------\n");

    archivoEnt = fopen(nombreArchivoEnt,"rb");

    if ( archivoEnt == NULL )
    {
        printf("\n\nNO HAY PEDIDOS ENTREGADOS\n\n");
        system("pause");
        return;
    }

    // imprimo los encabezados
    printf("\n%-5s   %-20s   %-20s   %s\n",
           "ID",
           "#HAMBURGUESAS",
           "#SALCHICHAS",
           "PRECIO");

    // mientras lea 1 pedido lo imprimo
    while( fread(&pedidoAux,sizeof(Pedido),1,archivoEnt) == 1 )
    {

        printf("\n%-5d   %-20d   %-20d   $%.2f\n",
           pedidoAux.idPedido,
           pedidoAux.cantHamburguesas,
           pedidoAux.cantSalchichas,
           pedidoAux.precioPedido);

        fgetc(archivoEnt);
    }

    fclose(archivoEnt);

    printf("\n");
    system("pause");
    return;
}

void salir(int totalProductosVendidos, float totalFacturado, char *nombreArchivoTotal)
{
    time_t t;
    struct tm *timeinfo;
    time(&t);
    timeinfo = localtime(&t);

    FILE *archivoLog = NULL;

    archivoLog = fopen(nombreArchivoTotal,"a");

    if ( archivoLog != NULL )
    {
        if ( totalProductosVendidos == 0 ){ // si no se vendio ningun producto, imprimo el mensaje correspondiente
            // imprimo la fecha y hora del cierre
            fprintf(archivoLog,"Hora: %02d:%02d:%02d\n", timeinfo->tm_hour, timeinfo->tm_min, timeinfo->tm_sec);
            fprintf(archivoLog,"--------------------------------\n");
            fprintf(archivoLog,"No se vendio ningun producto\n\n");
        }
        else {
            // imprimo la fecha y hora del cierre
            fprintf(archivoLog,"Hora: %02d:%02d:%02d\n", timeinfo->tm_hour, timeinfo->tm_min, timeinfo->tm_sec);
            fprintf(archivoLog,"--------------------------------\n");
            fprintf(archivoLog, "Cantidad de productos vendidos: %d\n", totalProductosVendidos);
            fprintf(archivoLog, "Cantidad de dinero facturado: %.2f\n\n", totalFacturado);
        }
    }

    fclose(archivoLog);
    return;
}
