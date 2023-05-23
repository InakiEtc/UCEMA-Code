#include <stdio.h>
#include <stdlib.h>

int main(){

    float sueld;
    printf("Ingrese el sueldo del trabajador: ");
    scanf("%f",&sueld);
    
    if (sueld<15000){
        printf("El sueldo ingresado es $%.2f \n",sueld);
        printf("El %% a incrementar es de 15%% \n");
        printf("El sueldo con el incremento es $%.2f \n",sueld*1.15);    
    }
    else if(sueld>=15000 && sueld<=25000){
        printf("El sueldo ingresado es $%.2f \n",sueld);
        printf("El %% a incrementar es de 10.5%% \n");
        printf("El sueldo con el incremento es $%.2f \n",sueld*1.105);     
    }
    else{
        printf("El sueldo ingresado es$ %.2f \n",sueld);
        printf("El %% a incrementar es de 8%% \n");
        printf("El sueldo con el incremento es $%.2f \n",sueld*1.08);  
    }
    
    return 0;
}