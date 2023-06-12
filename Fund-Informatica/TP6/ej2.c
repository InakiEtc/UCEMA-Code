#include <stdio.h>
#include <stdlib.h>

int area(); // ej2

int main (){

    int areaRectangulo;
    areaRectangulo = area();
    printf("El area del rectangulo es: %d", areaRectangulo); 

    return 0;
}


int area(){

    int base, altura, area;
    printf("Ingrese la base del rectangulo: ");
    scanf("%d", &base);
    printf("Ingrese la altura del rectangulo: ");
    scanf("%d", &altura);
    area = base * altura;
    
    return area;
}