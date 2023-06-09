#include <stdio.h>
#include <stdlib.h>

typedef struct{
    char razonSocial[20];
    char direccion[20];
    long int telefono;
    char nombreContacto[20];
    float ultCompra;
}Cliente;

int main(){

    Cliente clientes[5];

    for(int i=0; i<5; i++){
        printf("Ingrese los datos del cliente %d\n",i+1);
        printf("Razon social: ");
        fflush(stdin);
        gets(clientes[i].razonSocial);
        printf("Direccion: ");
        fflush(stdin);
        gets(clientes[i].direccion);
        printf("Telefono: ");
        scanf("%ld",&clientes[i].telefono);
        printf("Nombre de contacto: ");
        fflush(stdin);
        gets(clientes[i].nombreContacto);
        printf("Ultima compra: ");
        scanf("%f",&clientes[i].ultCompra);

        system("cls");
    }

    printf("\n\n");

    for(int i=0; i<5; i++){
        printf("Cliente %d\n",i+1);
        printf("Razon social: %s\n",clientes[i].razonSocial);
        printf("Direccion: %s\n",clientes[i].direccion);
        printf("Telefono: %ld\n",clientes[i].telefono);
        printf("Nombre de contacto: %s\n",clientes[i].nombreContacto);
        printf("Ultima compra: %.2f\n",clientes[i].ultCompra);
        
        printf("\n\n");
    }

    return 0;
}

