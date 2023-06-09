#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_CONTACTOS 100

typedef struct {
    char nombre[50];
    char telefono[20];
    char barrio[100];
    char relacion[20];
} Contacto;

Contacto contactos[MAX_CONTACTOS];
int numContactos = 0;

int main() {
    int opcion;

    do {
        printf("\n");
        printf("1. Agregar Contacto\n");
        printf("2. Mostar todos los C0ntactos\n");
        printf("3. Mostras contactos en un zona\n");
        printf("4. Salir\n");
        printf("Ingrese numero de opcion: ");
        scanf("%d", &opcion);
        getchar();
        system("cls");

        switch (opcion) {
            case 1: {
                if (numContactos >= MAX_CONTACTOS) {
                    printf("\nError: Se llego al max de contactos.\n");
                    break;
                }

                Contacto newContacto;

                printf("Ingrese nombre: ");
                fgets(newContacto.nombre, 50, stdin);
                newContacto.nombre[strcspn(newContacto.nombre, "\n")] = 0;

                printf("Ingrese numero de telefono: ");
                fgets(newContacto.telefono, 20, stdin);
                newContacto.telefono[strcspn(newContacto.telefono, "\n")] = 0;

                printf("Ingrese barrio: ");
                fgets(newContacto.barrio, 100, stdin);
                newContacto.barrio[strcspn(newContacto.barrio, "\n")] = 0;

                printf("Ingrese relacion (ej. Amigo, Familia, Trabajo): ");
                fgets(newContacto.relacion, 20, stdin);
                newContacto.relacion[strcspn(newContacto.relacion, "\n")] = 0;

                contactos[numContactos++] = newContacto;

                printf("\nSe anadio correctamente el contacto.\n");
                break;
            }
            case 2: {
                if (numContactos == 0) {
                    printf("\nNo se encontraron contactos.\n");
                    break;
                }

                printf("Contactos:\n");

                for (int i = 0; i < numContactos; i++) {
                    printf("%d. %s (%s)\n", i + 1, contactos[i].nombre, contactos[i].relacion);
                }
                break;
            }
            case 3: {
                char area[100];

                printf("Ingrese el area: ");
                fgets(area, 100, stdin);
                area[strcspn(area, "\n")] = 0;

                int numAmigos = 0;

                for (int i = 0; i < numContactos; i++) {
                    if (strcmp(contactos[i].relacion, "amigo") == 0 && strstr(contactos[i].barrio, area) != NULL) {
                        printf("\n%d. %s (%s)\n", numAmigos + 1, contactos[i].nombre, contactos[i].telefono);
                        numAmigos++;
                    }
                }

                if (numAmigos == 0) {
                    printf("\nNo hay amigos en %s.\n", area);
                }
                break;
            }
            case 4: {
                printf("\nSaliendo...\n");
                break;
            }
            default: {
                printf("\nOpcion Invalida.\n");
                break;
            }
        }
    } while (opcion != 4);

    return 0;
}