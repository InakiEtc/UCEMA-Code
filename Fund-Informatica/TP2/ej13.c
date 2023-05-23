#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){

    float peso,alt,imc;
    
    printf("Ingrese el peso en Kg: ");
    scanf("%f",&peso);
    printf("Ingrese la altura en Mts: ");
    scanf("%f",&alt); 


    imc = peso/(alt*alt);
    printf("Clasificacion:  \n");
    if(imc<40){
        if (imc<30){
            if (imc<27){
                if (imc<25){
                    if (imc<18){
                        printf("Peso bajo. Necesario valorar signos de desnutrición, IMC -> %.1f",imc);
                    }
                    else{
                        printf("Normal, IMC -> %.1f",imc);
                    }                    
                }
                else{
                    printf("Sobrepeso, IMC -> %.1f",imc);
                }                
            }
            else{
                printf("Obesidad grado I. Riesgo relativo alto para desarrollar enfermedades cardiovasculares, IMC -> %.1f",imc);   
            }
        }
        else{
            printf("Obesidad grado II. Riesgo relativo muy alto para el desarrollo de enfermedades cardiovasculares, IMC -> %.1f",imc);
        }
    }
    else{
        printf("Obesidad grado III Extrema o Mórbida. Riesgo relativo extremadamente alto para el desarrollo de enfermedades cardiovasculares, IMC-> %.1f",imc);
    }
    
    return 0;
}