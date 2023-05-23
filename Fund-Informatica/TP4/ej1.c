#include <stdio.h>
#include <stdlib.h>

int main(){

    int n, menor, pos;
    float suma, promedio;

    printf("Ingrese la cantidad de numeros a ingresar: ");
    scanf("%d", &n);

    int arr[n];

    for(int i=0; i<n; i++){
        printf("Ingrese el numero %d: ", i+1);
        scanf("%d", &arr[i]);
    }

    suma = 0;
    menor = arr[0];
    pos = 0;
    
    for(int i=0; i<n; i++){
        suma += arr[i];
        if(arr[i] < menor){
            menor = arr[i];
            pos = i;
        }
    }

    promedio = suma/n;

    printf("La sumatoria de los numeros es: %.2f\n", suma);
    printf("El promedio de los numeros es: %.2f\n", promedio);
    printf("El menor de los numeros es: %d y se encuentra en la posicion %d\n", menor, pos);

    return 0;
}