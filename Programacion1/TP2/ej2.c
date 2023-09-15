#include <stdio.h>
#include <stdlib.h>

typedef struct Proovedor{
    char nombre[50];
    int cuit;
    char condicion[10];
}Proovedor;

void cargarProovedor(Proovedor *p);
void buscarProovedor(Proovedor p, FILE *archivo, char *nombreArchivo);

int main(){

    Proovedor p;
    FILE *archivo = NULL;
    char *nombreArchivo="D:/UCEMA/Programacion1/TP2/archivos/Proovedores.bin"; 

    archivo = fopen(nombreArchivo, "wb");
    if (archivo == NULL) {
        printf("Error al abrir el archivo");
        return -1;
    }

    for(int i = 0; i < 20; i++){        
        cargarProovedor(&p);
        
        fwrite(&p, sizeof(Proovedor), 1, archivo);
        //fputc('\n', archivo);
    }

    fclose(archivo);
    buscarProovedor(p, archivo, nombreArchivo);

    return 0;
}

void cargarProovedor(Proovedor *p){
    printf("Ingrese el nombre del proovedor: ");
    fflush(stdin);
    gets(p->nombre);
    
    printf("Ingrese el cuit del proovedor: ");
    scanf("%d", &p->cuit);

    printf("Ingrese la condicion del proovedor: ");
    fflush(stdin);
    gets(p->condicion);

    system("cls");
}

void buscarProovedor(Proovedor p, FILE *archivo, char *nombreArchivo){
    
    int registro;

    printf("Ingrese el numero de registro a buscar: ");
    scanf("%d", &registro);

    archivo = fopen(nombreArchivo, "rb");
    if (archivo == NULL) {
        printf("Error al abrir el archivo");
        return;
    }

    fseek(archivo, sizeof(Proovedor)*(registro-1), SEEK_SET);
    fread(&p, sizeof(Proovedor), 1, archivo);

    printf("\nNombre: %s\n", p.nombre);
    printf("Cuit: %d\n", p.cuit);
    printf("Condicion: %s\n\n", p.condicion);

    fclose(archivo);

}
