#include <stdio.h>
#include <stdlib.h>

int main(){

    int l1,l2,l3;
    l1=0;
    l2=0;
    l3=0;
    
    while (l1<=0){
        printf("Valor 1er lado (mayor 0): ");
        scanf("%d",&l1);  
    }
    while (l2<=0){
        printf("Valor 2do lado (mayor 0): ");
        scanf("%d",&l2);  
    }
    while (l3<=0){
        printf("Valor 3er lado (mayor 0): ");
        scanf("%d",&l3);  
    }

    if (l1==l2 && l1==l3){
        printf("Es un tringulo equilatero");
    }
    else if(l1==l2 || l2==l3 || l1==l3){
        printf("Es un tringulo isosceles");
    }
    else{
        printf("Es un tringulo escaleno");
    }
    return 0;
    
}