#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(){

    float mat1,mat2,mat3,mat4,prm;
    
    printf("Ingrese las nota final de la Materia 1: ");
    scanf("%f",&mat1);
    printf("Ingrese las nota final de la Materia 2: ");
    scanf("%f",&mat2); 
    printf("Ingrese las nota final de la Materia 3: ");
    scanf("%f",&mat3);
    printf("Ingrese las nota final de la Materia 4: ");
    scanf("%f",&mat4);

    prm = (mat1+mat2+mat3+mat4)/4;
    if(prm<10){
        if (prm<8){
            if (prm<6){
                if (prm<=4){
                    if (prm==4){
                        printf("Promedio Regular -> %.1f",prm);
                    }
                    else{
                        printf("Promedio Insuficiente -> %.1f",prm);
                    }                    
                }
                else{
                    printf("Promedio Bueno -> %.1f",prm);
                }                
            }
            else{
                printf("Muy buen Promedio -> %.1f",prm);   
            }
        }
        else{
            printf("Excelente Promedio -> %.1f",prm);
        }
    }
    else{
        if (prm>10){
            printf("El promedio no puede ser mayor a 10, Ingrese notas validas");
        }
        else{
        printf("Promedio Sobresaliente! -> %.1f",prm);
        }
    }
    
    return 0;

}