#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>


int main(){

    char a,b,c;
    printf("Ingrese 1er Inicial: ");
    scanf(" %c",&a);
    printf("Ingrese 2da Inicial: ");
    scanf(" %c",&b);
    printf("Ingrese 3er Inicial: ");
    scanf(" %c",&c);

    printf("Ud. Ingreso: %c-%c-%c",toupper(a),toupper(b),toupper(c));
    
    return 0;

}
