//Ordenamiento por metodo de Intercambio
void exchange(int array[], int size){
    int aux;
    for(int i = 0; i < size; i++){
        for(int j = i+1; j < size; j++){
            if(array[i] > array[j]){
                aux = array[i];
                array[i] = array[j];
                array[j] = aux;
            }
        }
    }
}

//Ordenamiento por metodo de Insersion
void insertion(int array[], int size){
    int aux,j;
    for(int i = 1; i < size; i++){
        aux = array[i];
        for(j = i; j>0 && array[j-1] > aux; j--){
            array[j] = array[j-1];            
        }
        array[j] = aux;
    }
}

//Ordenamiento por metodo de burbuja
void bubble(int array[], int size){
    int aux,sino=1;
    for(int i = 0; i < size-1 && sino; i++){
        sino = 0;
        for(int j = 0; j < size-i-1; j++){
            if(array[j] > array[j+1]){
                sino = 1;
                aux = array[j];
                array[j] = array[j+1];
                array[j+1] = aux;
            }
        }
    }
}

//Ordenamiento por metodo de Shell
void shell(int array[], int size){
    int aux,salto,k;
    for(salto = size/2; salto > 0; salto /= 2){
        for(int i = salto; i < size; i++){
            for (int j = i - salto; j >= 0; j -= salto) {
                k= j + salto;
                if (array[j] > array[k]) {
                    aux = array[j];
                    array[j] = array[k];
                    array[k] = aux;
                } else {
                    break;
                }
            }            
        }       
    }
}

