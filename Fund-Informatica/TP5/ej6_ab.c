#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

typedef struct{
    char nombreCliente[30];
    int unidadesSolicitadas;
    float precioUnitario;
    char estado;
}FacturaCliente;

int main(){

    int clie;

    printf("Cuantos clientes desea ingresar? ");
    scanf("%d",&clie);

    FacturaCliente clientes[clie];

    for(int i=0; i<clie; i++){
        printf("Ingrese el nombre del cliente %d: ",i+1);
        fflush(stdin);
        gets(clientes[i].nombreCliente);
        printf("Ingrese la cantidad de unidades solicitadas: ");
        scanf("%d",&clientes[i].unidadesSolicitadas);
        printf("Ingrese el precio unitario: ");
        scanf("%f",&clientes[i].precioUnitario);
        printf("Ingrese el estado: ");
        fflush(stdin);
        scanf("%c",&clientes[i].estado);

        system("cls");
    }

    printf("Listado de clientes con estado Moroso: \n");
    for(int i=0; i<clie; i++){
        if(toupper(clientes[i].estado) == 'M'){
            printf("Nombre: %s\n",clientes[i].nombreCliente);
            printf("Unidades solicitadas: %d\n",clientes[i].unidadesSolicitadas);
            printf("Precio unitario: %.2f\n",clientes[i].precioUnitario);
            printf("Estado: %c\n",clientes[i].estado);
            printf("\n");
        }
    }

    printf("Presione una tecla para continuar");
    getch();
    system("cls");

    printf("Listado de clientes con estado Pagado y factura mayor a 1000: \n");
    for(int i=0; i<clie; i++){
        if(toupper(clientes[i].estado) == 'P' && clientes[i].unidadesSolicitadas*clientes[i].precioUnitario > 1000){
            printf("Nombre: %s\n",clientes[i].nombreCliente);
            printf("Unidades solicitadas: %d\n",clientes[i].unidadesSolicitadas);
            printf("Precio unitario: %.2f\n",clientes[i].precioUnitario);
            printf("Estado: %c\n",clientes[i].estado);
            printf("\n");
        }
    }

    return 0;

}
