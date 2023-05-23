#include <stdio.h>
#include <stdlib.h>

int main(){
 
    for(int i = 1; i < 11; i++){
        for(int j = 1; j <= i; j++){
            printf("*");
        }
        printf("\n");
    }
    for(int i = 11 ; i > 0; i--){
        for(int j = 0; j < i; j++){
            printf("*");
        }
        printf("\n");
    }

    return 0;
}  