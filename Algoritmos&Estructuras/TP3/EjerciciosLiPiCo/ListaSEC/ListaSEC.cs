using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ListaSEC
{
    internal class ListaSEC
    {
        Nodo C;
        public ListaSEC() { C=new Nodo(); }
        public void AgregarAlPrincipio(Nodo pNodo)
        {

            if (C.Siguiente==null) //Lista Vacía
            {
                C.Siguiente=pNodo;
                pNodo.Siguiente = pNodo;
            }
            else //Lista con al menos un nodo
            {
                Nodo ult = RetornaUltimo();
                pNodo.Siguiente = C.Siguiente;
                C.Siguiente= pNodo;
                ult.Siguiente = pNodo;
            }
        }
        public void AgregarAlFinal(Nodo pNodo)
        {

            if (C.Siguiente==null) //Lista Vacía
            {
                C.Siguiente=pNodo;
                pNodo.Siguiente = pNodo;
            }
            else //Lista con al menos un nodo
            {
                RetornaUltimo().Siguiente = pNodo;
                pNodo.Siguiente = C.Siguiente;
            }

        }
        public void AgregarPosicionN(Nodo pNodo, int pPos)
        {

            try
            {
                if (pPos<1 || pPos>Cantidad()+1) throw new Exception("La posición es inválida !!!"); //Escenario no posible
                //Estamos en condiciones de evaluar los distintos escenarios de insertar en Pos N
                if (pPos==1) AgregarAlPrincipio(pNodo); //Si pPos==1 llamamos a Agregar al principio
                if (pPos==Cantidad()+1) AgregarAlFinal(pNodo); //Si pPos==Cantidad()+1 llamamos a Agregar al final
                else if (pPos>1 && pPos<Cantidad()+1)
                {
                    Nodo aux = RetornaNodoPosNInterna(pPos-1); //Nodo que se encuentra en la posición anterior al lugar que deseo insertar el nuevo nodo
                    pNodo.Siguiente=aux.Siguiente;
                    aux.Siguiente=pNodo;
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public void EliminarAlPrincipio()
        {           
            if (C.Siguiente==null) throw new Exception("No hay elementos para eliminar"); //Escenario no posible
            Nodo nodoAux = RetornaUltimo();
            if (Cantidad() == 1) C.Siguiente = null;
            else
            {
                C.Siguiente = C.Siguiente.Siguiente;
                nodoAux.Siguiente = C.Siguiente;
            }
        }
        public void EliminarAlFinal()
        {
            if (C.Siguiente==null) throw new Exception("No hay elementos para eliminar"); //Escenario no posible
            if (Cantidad()==1) C.Siguiente=null;
            else
            {
                Nodo aux = RetornaNodoPosNInterna(Cantidad()-1);
                aux.Siguiente=C.Siguiente;
            }
        }
        public void EliminarPosicionN(int pPos)
        {
            try
            {
                if (pPos < 1 || pPos > Cantidad() + 1) throw new Exception("La posición es inválida"); //Escenario no posible
                //Estamos en condiciones de evaluar los distintos escenarios de insertar en Pos N
                if (pPos == 1) EliminarAlPrincipio();
                if (pPos == Cantidad() + 1) EliminarAlFinal();
                else if (pPos > 1 && pPos < Cantidad() + 1)
                {
                    Nodo aux = RetornaNodoPosNInterna(pPos - 1); //Nodo que se encuentra en la posición anterior al lugar que deseo insertar el nuevo nodo                  
                    Nodo nodo = aux.Siguiente;
                    aux.Siguiente = nodo.Siguiente;
                    nodo.Siguiente = null;                 
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public void SwapNodos(int pPos1, int pPos2)
        {
            if (pPos1<1 || pPos1>Cantidad()+1 || pPos2<1 || pPos2>Cantidad()+1) throw new Exception("La posición es inválida");
            if(pPos1==pPos2) throw new Exception("Las posiciones son iguales");
            if (pPos1 > pPos2) { int aux = pPos1; pPos1 = pPos2; pPos2 = aux; } // pongo la pos mas chica primero

            Nodo nodo1 = RetornaNodoPosNInterna(pPos1);
            Nodo nodo2 = RetornaNodoPosNInterna(pPos2);
            Nodo nodoAnt1 = pPos1 == 1 ? null : RetornaNodoPosNInterna(pPos1 - 1);
            Nodo nodoAnt2 = RetornaNodoPosNInterna(pPos2 - 1);

            if (pPos1 == 1)
            {
                Nodo ult = RetornaUltimo();
                if (ult == nodo2)
                {
                    C.Siguiente = nodo2;
                    nodo2.Siguiente = nodo1.Siguiente;
                    nodo1.Siguiente = nodo2;
                    nodoAnt2.Siguiente = nodo1;
                }
                else
                {
                    C.Siguiente = nodo2;
                    nodoAnt2.Siguiente = nodo1;
                    Nodo temp = nodo2.Siguiente;
                    nodo2.Siguiente = nodo1.Siguiente;
                    nodo1.Siguiente = temp;
                    ult.Siguiente = C.Siguiente;
                }                                
            }
            else if (pPos2 == pPos1 + 1)
            {
                nodoAnt1.Siguiente = nodo2;
                nodo1.Siguiente = nodo2.Siguiente;
                nodo2.Siguiente = nodo1;
            }
            else
            {
                nodoAnt1.Siguiente = nodo2;
                nodoAnt2.Siguiente = nodo1;
                Nodo aux = nodo1.Siguiente;
                nodo1.Siguiente = nodo2.Siguiente;
                nodo2.Siguiente = aux;
            }
        }

        public Nodo RetornaNodoPosN(int pPos)
        {
            if (pPos<1 || pPos>Cantidad()) throw new Exception("La posición es inválida !!!"); //Escenario no posible
            return RetornaNodoPosNRecursiva(C.Siguiente, pPos).CloneTipado();
        }
        private Nodo RetornaNodoPosNInterna(int pPos)
        {
            if (pPos<1 || pPos>Cantidad()) throw new Exception("La posición es inválida !!!"); //Escenario no posible
            return RetornaNodoPosNRecursiva(C.Siguiente, pPos);
        }
        private Nodo RetornaNodoPosNRecursiva(Nodo pNodo, int pPos)
        {
            Nodo aux = pNodo;
            if (pPos!=1) aux = RetornaNodoPosNRecursiva(pNodo.Siguiente, pPos-1);
            return aux;
        }
        public Nodo RetornaPrimero() { return C.Siguiente; }
        public Nodo? RetornaUltimo()
        {
            return RetornaUltimoRecursiva(C.Siguiente,C.Siguiente);
        }
        public int Cantidad()
        {
            if (C.Siguiente == null) return 0; // Lista vacía
            return CantidadRecursiva(C.Siguiente, C.Siguiente);
        }
        private int CantidadRecursiva(Nodo pNodo, Nodo nodoInicial)
        {
            if (pNodo.Siguiente == nodoInicial) return 1; // Si el siguiente nodo es el inicial, hemos completado el ciclo
            return 1 + CantidadRecursiva(pNodo.Siguiente, nodoInicial);
        }
        private Nodo? RetornaUltimoRecursiva(Nodo? pNodo,Nodo? nodoInicial)
        {
            Nodo? auxNodo = pNodo;
            if (auxNodo !=null && auxNodo.Siguiente == nodoInicial)
            {
                return auxNodo;                
            }
            return RetornaUltimoRecursiva(auxNodo.Siguiente,nodoInicial);
        }

    }
}
