#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){

    srand(time(NULL));

    int arr[5000];
    int pares=0;
    
    for(int i=0; i<5000; i++){
        arr[i] = rand() % 1001;
        printf("%d\n", arr[i]);
        if(arr[i] < 352 && arr[i] % 2 == 0){
            pares++;
        }
    }
    printf("La cantidad de pares menores a 352 es: %d\n", pares);

    return 0;
}

