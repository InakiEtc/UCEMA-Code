#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){

    srand(time(NULL));
    FILE *archivo = NULL;
    char *nombreArchivo="D:/UCEMA/Programacion1/TP2/archivos/Random.bin";

    archivo = fopen(nombreArchivo, "wb");
    if (archivo == NULL) {
        printf("Error al abrir el archivo");
        return -1;
    }
    
    //Hacer un programa que guarde en un archivo binario 500 números aleatorios entre 0 y 
    //1000. Al finalizar, se debe indicar el tamaño total del archivo en bytes. 

    int p = 0;         

    for(int i = 0; i < 500; i++){        
        p = rand() % 1001;
        fwrite(&p, sizeof(int), 1, archivo);        
    }

    fseek(archivo, 0, SEEK_END);
    printf("El tamano del archivo es de %ld bytes", ftell(archivo));

    fclose(archivo);

    return 0;
}