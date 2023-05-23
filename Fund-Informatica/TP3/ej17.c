#include <stdio.h>
#include <stdlib.h>

int main(){
 
    for(int i = 1; i < 11; i++){
        for(int k = 11; k > i; k--){
            printf(" "); 
        }
        for(int j = 1; j <= i; j++){      
            printf(" *");
        }
        printf("\n");
    }

    return 0;
}
