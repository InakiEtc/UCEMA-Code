//Hacer una función, que dado los valores de LA CORRIENTE (I), y de la TENSION (V), calcule 
//el valor la resistencia (R) mediante la ley de Ohm.

#include <stdio.h>
#include <stdlib.h>

float calculoRes(float I, float V);
float calculoCor(float R, float V);
float calculoTen(float R, float I);



int main(){

    int opcion;
    float I, V, R;

    while (opcion != 4){
        printf("1 - Calcular la Resistencia(R)\n");
        printf("2 - Calcular la Corriente(I)\n");
        printf("3 - Calcular la Tension(V)\n");
        printf("4 - Salir\n");
        printf("Ingrese la opcion deseada: \n");
        scanf("%d", &opcion);

        system("cls");

        switch (opcion){
        case 1:
            printf("Ingrese el valor de la corriente(I): \n");
            scanf("%f", &I);
            printf("Ingrese el valor de la tension(V): \n");
            scanf("%f", &V);

            R = calculoRes(I, V);

            printf("\nEl valor de la resistencia(R) es: %.2f\n", R);

            system("pause");
            system("cls");

            break;
        case 2:
            printf("Ingrese el valor de la resistencia(R): \n");
            scanf("%f", &R);
            printf("Ingrese el valor de la tension(V): \n");
            scanf("%f", &V);

            I = calculoCor(R, V);

            printf("\nEl valor de la corriente(I) es: %.2f\n", I);

            system("pause");
            system("cls");

            break;
        case 3:
            printf("Ingrese el valor de la resistencia(R): \n");
            scanf("%f", &R);
            printf("Ingrese el valor de la corriente(I): \n");
            scanf("%f", &I);

            V = calculoTen(R, I);

            printf("\nEl valor de la tension(V) es: %.2f\n", V);

            system("pause");
            system("cls");

            break;
        case 4:
            printf("Saliendo...\n");
            break;
        default:
            printf("Opcion incorrecta\n");
            break;
        }
    }
    

    return 0;
}

float calculoRes(float I, float V){
    float R;
    R = V / I;
    return R;
}

float calculoCor(float R, float V){
    float I;
    I = V / R;
    return I;
}

float calculoTen(float R, float I){
    float V;
    V = R * I;
    return V;
}
