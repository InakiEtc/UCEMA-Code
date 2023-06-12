#include <stdio.h>
#include <stdlib.h>

int area(int base, int altura); 

int main (){

    int base, altura, areaRectangulo;
    printf("Ingrese la base del rectangulo: ");
    scanf("%d", &base);
    printf("Ingrese la altura del rectangulo: ");
    scanf("%d", &altura);
    areaRectangulo = area(base, altura);
    printf("El area del rectangulo es: %d", areaRectangulo);

    return 0;
}

int area(int base, int altura){

    int area;
    area = base * altura;
    
    return area;
}