#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(){

    srand(time(NULL));
    int arr[10];

    for (int i=0; i<10; i++){
        arr[i] = rand() % 11 + 1;
        printf("%d ", arr[i]);
    }

    printf("\n");

    for (int i=9; i>=0; i--){
        printf("%d ", arr[i]);
    }

    printf("\n");

    return 0;
}
