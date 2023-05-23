#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main() {
	
	float lad1,lad2,diagonal;
	
	printf("Ingrese el valor del cateto 1: ");
	scanf("%f",&lad1);
	
	printf("Ingrese el valor del cateto 2: ");
	scanf("%f",&lad2);
	
	diagonal=sqrt((lad1*lad1)+(lad2*lad2));
	printf("La hipotenusa del triangulo es: %.2f \n",diagonal);
    
	return 0;
}