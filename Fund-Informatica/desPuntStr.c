#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#include <stdbool.h>

#define MAX 5

typedef struct {
    char nombre[30];
    char apellido[30];
    int nroSocio;
    char direccion[50];
    int telefono;
    float deuda;
    char actividad[6];
} Socio;

void agregarSocio(Socio sociosArr[],Socio *pSocio,int *pNumSocios,char *actividades[]);
void reportSociosActividad(Socio sociosArr[],int numSocios);
void actualizarDeuda(Socio sociosArr[],int numSocios);
void reportSociosDeuda(Socio sociosArr[],int numSocios);

int main(){

    int opcion, numSocios=0;
    int *pNumSocios = &numSocios;
    Socio sociosArr[MAX], socio;
    Socio *pSocio = &socio;
    char *actividades[4] = {"futbol", "tenis", "paddle", "patin"};
  
    do{
        printf("1. Agregar Socio Nuevo \n");
        printf("2. Reporte de Socios x Actividad \n");
        printf("3. Actualizar estado de Deuda \n");
        printf("4. Listar Socios con Deudas \n");
        printf("5. Salir \n");
        printf("Elija una opcion: ");
        scanf("%d",&opcion);

        switch(opcion){
            case 1:
                agregarSocio(sociosArr,pSocio,pNumSocios,actividades);  
                break;  
            case 2:
                reportSociosActividad(sociosArr,numSocios);
                break;
            case 3:
                actualizarDeuda(sociosArr,numSocios);
                break;
            case 4:
                reportSociosDeuda(sociosArr,numSocios);
                break;
            case 5:
                system("cls");
                printf("Chau! Saliendo... \n");
                break;
            default:
                system("cls");
                printf("Opcion Invalida \n");
                system("Pause");
                system("cls");
                break;                
        }
    }while (opcion != 5);   
    return 0;
}

void agregarSocio(Socio sociosArr[],Socio *pSocio,int *pNumSocios,char *actividades[]){
    char op;
    bool ok;
    
    do{
        if(*pNumSocios >= MAX){
            printf("No hay mas espacio para agregar socios \n");
            break; 
        }    
        system("cls");    
        printf("Ingrese nombre del socio: ");
        fflush(stdin);        
        gets(pSocio->nombre);
        printf("Ingrese apellido del socio: ");
        fflush(stdin);        
        gets(pSocio->apellido);
        printf("Ingrese numero del socio: ");       
        scanf("%d",&pSocio->nroSocio);
        printf("Ingrese direccion del socio: ");
        fflush(stdin);        
        gets(pSocio->direccion);
        printf("Ingrese telefono del socio: ");       
        scanf("%d",&pSocio->telefono);
        printf("Ingrese la deuda del socio: ");       
        scanf("%f",&pSocio->deuda);    
        do{
            ok = false;
            printf("Ingrese la actividad del socio (futbol,tenis,paddle,patin): ");
            fflush(stdin);
            gets(pSocio->actividad);
            
            for(int i=0; i<4; i++){
                if(strcmp(strlwr(pSocio->actividad),strlwr(actividades[i])) == 0){
                    ok = true;
                    break;
                }
            }
            if (ok == false){
                printf("Actividad invalida \n");
            }        
        } while(ok == false); 

        sociosArr[*pNumSocios] = *pSocio;
        (*pNumSocios)++;

        printf("Desea agregar otro socio? (s/n): ");
        scanf(" %c",&op);
    }while(tolower(op) == 's');
    system("Pause");
    system("cls");
}

void reportSociosActividad(Socio sociosArr[],int numSocios){
    system("cls");
    for (int i=0; i<numSocios; i++){
        printf("-------------------------\n");
        printf("Nombre y apellido: %s %s \n",sociosArr[i].nombre,sociosArr[i].apellido);
        printf("Actividad: %s \n",sociosArr[i].actividad);
    }
    printf("-------------------------\n");
    printf("Cantidad de Socios: %d\n",numSocios);
    printf("-------------------------\n");

    system("Pause");
    system("cls");
}

void actualizarDeuda(Socio sociosArr[],int numSocios){
    system("cls");
    char apelli[30];
    char op;

    printf("Ingrese apellido a buscar: ");
    fflush(stdin);
    gets(apelli);

    for(int i=0; i<numSocios; i++){
        if(strcmp(strlwr(apelli),strlwr(sociosArr[i].apellido)) == 0){
            printf("%s %s tiene una deuda de: %.2f \n",sociosArr[i].nombre,sociosArr[i].apellido,sociosArr[i].deuda);

            printf("Desea actualizarla? (s/n): ");
            scanf(" %c",&op);
            
            while(tolower(op) == 's'){
                printf("Ingrese nueva deuda: ");
                scanf("%f",&sociosArr[i].deuda);
                printf("%s %s tiene una deuda de: %.2f \n",sociosArr[i].nombre,sociosArr[i].apellido,sociosArr[i].deuda);

                printf("Desea actualizarla? (s/n): ");
                scanf(" %c",&op);
            }
            system("Pause");
            system("cls");
            return;
        }
    }
    printf("No se econtro el apellido entre los socios\n");
    system("Pause");
    system("cls");
}

void reportSociosDeuda(Socio sociosArr[],int numSocios){
    system("cls");
    int sociosAdeudados = 0;
    float suma = 0;

    for (int i=0; i<numSocios; i++){
        if (sociosArr[i].deuda > 0){
            printf("-------------------------\n");
            printf("Nombre y apellido: %s %s \n",sociosArr[i].nombre,sociosArr[i].apellido);
            printf("Monto adeudado ($): %.2f \n",sociosArr[i].deuda);
            sociosAdeudados++;
            suma += sociosArr[i].deuda;
        }    
    }
    printf("-------------------------\n");
    printf("Total clientes que adeudan: %d\n",sociosAdeudados);
    printf("Monto total adeudado: %.2f\n",suma);
    printf("-------------------------\n");

    system("Pause");
    system("cls");
}