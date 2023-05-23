#include <stdio.h>
#include <stdlib.h>

int main(){

    float dep;
      
    printf("Ingrese el importe del deposito: ");
    scanf("%f",&dep);

    printf("Si lo deposita por 3 meses obtendra $%.3f con un interes de 3%% mensual \n",dep + (3*(dep*0.03)));
    printf("Si lo deposita por 6 meses obtendra $%.3f con un interes de 3,2%% mensual \n",dep + (3*(dep*0.032)));
    printf("Si lo deposita por 12 meses obtendra $%.3f con un interes de 3,9%% mensual \n",dep + (3*(dep*0.039)));

    return 0;
    
}
