#include <stdio.h>
#include <stdlib.h>

int main(){

    int n1,n2,suma = 0; 
    char sino = 's';
    
    while (sino != 'n'){
        printf("Ingrese un numero: ");
        scanf("%d",&n1);

        printf("Ingrese otro numero: ");
        scanf("%d",&n2);

        printf("La suma es: %d \n",n1+n2);
        suma += n1+n2;

        printf("Desea realizar otra suma? s->Si / n->No : ");
        scanf(" %c",&sino);
        
    } 

    printf("La suma de las sumas es: %d",suma);
    return 0;
}