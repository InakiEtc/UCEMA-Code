#include <stdio.h> 
#include <stdlib.h>
#include <time.h> 

int main() {

	int numero;
	
	srand(time(NULL)); 
	numero=rand() % 101; 
	
	printf("%d",numero);

	return 0;
}