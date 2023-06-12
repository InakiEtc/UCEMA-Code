#include <stdio.h>
#include <stdlib.h>

int suma(int num1, int num2);
int resta(int num1, int num2);
int multiplicacion(int num1, int num2);
int division(int num1, int num2);

int main (){

    int num1, num2, opcion, resultado;
    while (opcion != 5){
        printf("1. Sumar\n");
        printf("2. Restar\n");
        printf("3. Multiplicar\n");
        printf("4. Dividir\n");
        printf("5. Salir\n");
        printf("Ingrese la opcion deseada: \n");
        scanf("%d", &opcion);

        system("cls");

        switch (opcion){
            case 1:
                resultado = suma(num1, num2);
                printf("\nEl resultado de la suma es: %d\n", resultado);

                system("pause");
                system("cls");

                break;
            case 2:
                resultado = resta(num1, num2);
                printf("\nEl resultado de la resta es: %d\n", resultado);

                system("pause");
                system("cls");

                break;
            case 3:
                resultado = multiplicacion(num1, num2);
                printf("\nEl resultado de la multiplicacion es: %d\n", resultado);

                system("pause");
                system("cls");

                break;
            case 4:
                resultado = division(num1, num2);
                printf("\nEl resultado de la division es: %d\n", resultado);

                system("pause");
                system("cls");

                break;
            case 5:
                printf("Saliendo...\n");
                break;
            default:
                printf("Opcion incorrecta\n");
                break;
        }
    }

    return 0;
}

int suma(int num1, int num2){
    printf("Ingrese el primer numero: ");
    scanf("%d", &num1);
    printf("Ingrese el segundo numero: ");
    scanf("%d", &num2);
    return num1 + num2;
}

int resta(int num1, int num2){
    printf("Ingrese el primer numero: ");
    scanf("%d", &num1);
    printf("Ingrese el segundo numero: ");
    scanf("%d", &num2);
    return num1 - num2;
}

int multiplicacion(int num1, int num2){
    printf("Ingrese el primer numero: ");
    scanf("%d", &num1);
    printf("Ingrese el segundo numero: ");
    scanf("%d", &num2);
    return num1 * num2;
}

int division(int num1, int num2){
    printf("Ingrese el primer numero: ");
    scanf("%d", &num1);
    printf("Ingrese el segundo numero: ");
    scanf("%d", &num2);
    return num1 / num2;
}
