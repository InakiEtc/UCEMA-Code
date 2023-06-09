#include <stdio.h>
#include <stdlib.h>

struct Deporte{
    char nombreEquipo[30];
    int victorias;
    int derrotas;
};

typedef struct{
    struct Deporte deporte_basquet;
    int perdidas;
    int rebotes;
    char nombreTriplista[30];
    int numTriplista;
}Basquet;

typedef struct{
    struct Deporte deporte_futbol;
    int empates;
    int golesAFavor;
    int golesEnContra;
    char nombreGoleador[30];
    int numGoleador;
}Futbol;

int main(){

    Basquet basquet[5];
    Futbol futbol[5];

    for(int i=0; i<5; i++){
        printf("Ingrese el nombre del equipo de basquet %d: ",i+1);
        fflush(stdin);
        gets(basquet[i].deporte_basquet.nombreEquipo);
        printf("Ingrese la cantidad de victorias: ");
        scanf("%d",&basquet[i].deporte_basquet.victorias);
        printf("Ingrese la cantidad de derrotas: ");
        scanf("%d",&basquet[i].deporte_basquet.derrotas);
        printf("Ingrese la cantidad de perdidas: ");
        scanf("%d",&basquet[i].perdidas);
        printf("Ingrese la cantidad de rebotes: ");
        scanf("%d",&basquet[i].rebotes);
        printf("Ingrese el nombre del triplista: ");
        fflush(stdin);
        gets(basquet[i].nombreTriplista);
        printf("Ingrese el numero del triplista: ");
        scanf("%d",&basquet[i].numTriplista);

        system("cls");
    }

    for(int i=0; i<5; i++){
        printf("Ingrese el nombre del equipo de futbol %d: ",i+1);
        fflush(stdin);
        gets(futbol[i].deporte_futbol.nombreEquipo);
        printf("Ingrese la cantidad de victorias: ");
        scanf("%d",&futbol[i].deporte_futbol.victorias);
        printf("Ingrese la cantidad de derrotas: ");
        scanf("%d",&futbol[i].deporte_futbol.derrotas);
        printf("Ingrese la cantidad de empates: ");
        scanf("%d",&futbol[i].empates);
        printf("Ingrese la cantidad de goles a favor: ");
        scanf("%d",&futbol[i].golesAFavor);
        printf("Ingrese la cantidad de goles en contra: ");
        scanf("%d",&futbol[i].golesEnContra);
        printf("Ingrese el nombre del goleador: ");
        fflush(stdin);
        gets(futbol[i].nombreGoleador);
        printf("Ingrese el numero del goleador: ");
        scanf("%d",&futbol[i].numGoleador);

        system("cls");
    }

    printf("Listado de los mejores triplistas de cada equipo: \n");
    for(int i=0; i<5; i++){
        printf("Nombre del equipo: %s\n",basquet[i].deporte_basquet.nombreEquipo);
        printf("Nombre del triplista: %s\n",basquet[i].nombreTriplista);
        printf("Numero del triplista: %d\n",basquet[i].numTriplista);
        printf("\n");
    }

    printf("Presione una tecla para continuar");
    getch();
    system("cls");

    printf("Maximo goleador de la liga de Futbol: \n");
    int maxGoles = 0;
    int posMaxGoles = 0;
    for(int i=0; i<5; i++){
        if(futbol[i].numGoleador > maxGoles){
            maxGoles = futbol[i].numGoleador;
            posMaxGoles = i;
        }
    }
    printf("Nombre del equipo: %s\n",futbol[posMaxGoles].deporte_futbol.nombreEquipo);
    printf("Nombre del goleador: %s\n",futbol[posMaxGoles].nombreGoleador);
    printf("Numero del goleador: %d\n",futbol[posMaxGoles].numGoleador);
    printf("\n");

    printf("Presione una tecla para continuar");
    getch();
    system("cls");

    printf("Equipo ganador de la liga de futbol: \n");
    int maxPuntos = 0;
    int posMaxPuntos = 0;
    for(int i=0; i<5; i++){
        int puntos = (futbol[i].deporte_futbol.victorias * 3) + (futbol[i].empates * 1) + (futbol[i].deporte_futbol.derrotas * 0);
        if(puntos > maxPuntos){
            maxPuntos = puntos;
            posMaxPuntos = i;
        }
    }
    printf("Nombre del equipo: %s\n",futbol[posMaxPuntos].deporte_futbol.nombreEquipo);
    printf("Puntos: %d\n",maxPuntos);
    printf("\n");

    printf("Presione una tecla para continuar");
    getch();
    system("cls");

    // Mostrar el equipo ganador de la liga de basquet (el que tiene mas victorias)
    printf("Equipo ganador de la liga de basquet: \n");
    int maxVictorias = 0;
    int posMaxVictorias = 0;
    for(int i=0; i<5; i++){
        if(basquet[i].deporte_basquet.victorias > maxVictorias){
            maxVictorias = basquet[i].deporte_basquet.victorias;
            posMaxVictorias = i;
        }
    }
    printf("Nombre del equipo: %s\n",basquet[posMaxVictorias].deporte_basquet.nombreEquipo);
    printf("Victorias: %d\n",maxVictorias);
    printf("\n");

    printf("Presione una tecla para continuar");
    getch();
    system("cls");

    return 0;
}