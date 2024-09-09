using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ListaDE
{
    internal class ListaDE
    {
        Nodo C;
        public ListaDE() { C=new Nodo(); }
        public void AgregarAlPrincipio(Nodo pNodo)
        {

            if (C.Siguiente==null) //Lista Vacía
            {
                C.Siguiente=pNodo;
            }
            else //Lista con al menos un nodo
            {            
                pNodo.Siguiente = C.Siguiente;
                C.Siguiente.Anterior = pNodo;
                C.Siguiente= pNodo;
            }

        }
        public void AgregarAlFinal(Nodo pNodo)
        {

            if (C.Siguiente==null) //Lista Vacía
            {
                C.Siguiente=pNodo;
            }
            else //Lista con al menos un nodo
            {
                RetornaUltimo().Siguiente = pNodo;
                pNodo.Anterior = RetornaUltimo();
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
                    pNodo.Anterior=aux;
                    aux.Siguiente=pNodo;
                    pNodo.Siguiente.Anterior=pNodo;

                }
            }
            catch (Exception ex) { throw ex; }
        }
        public void EliminarAlPrincipio()
        {
            if (C.Siguiente==null) throw new Exception("No hay elementos para eliminar"); //Escenario no posible
            C.Siguiente=C.Siguiente.Siguiente;
            if (C.Siguiente!=null) C.Siguiente.Anterior=null;
        }
        public void EliminarAlFinal()
        {
            if (C.Siguiente==null) throw new Exception("No hay elementos para eliminar"); //Escenario no posible
            if (Cantidad()==1) C.Siguiente=null;
            else
            {
                Nodo aux = RetornaNodoPosNInterna(Cantidad()-1);
                aux.Siguiente=null;
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
                    if (nodo.Siguiente != null) nodo.Siguiente.Anterior = aux;
                    nodo.Siguiente = null;         
                    nodo.Anterior = null;
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
            Nodo nodoSig1 = nodo1.Siguiente;
            Nodo nodoSig2 = nodo2.Siguiente;

            if (pPos1 == 1 && pPos2 != pPos1 + 1)
            {
                C.Siguiente = nodo2;
                nodo2.Anterior = null;
                nodo2.Siguiente = nodoSig1;
                nodo1.Anterior = nodoAnt2;
                nodo1.Siguiente = nodoSig2;
                if (nodoSig2 != null) nodoSig2.Anterior = nodo1;
                nodoAnt2.Siguiente = nodo1;
                nodoSig1.Anterior = nodo2;

            }
            else if (pPos2 == pPos1 + 1)
            {
                if (pPos1 == 1) C.Siguiente = nodo2;
                nodo2.Anterior = nodoAnt1;
                nodo2.Siguiente = nodo1;
                nodo1.Siguiente = nodoSig2;
                if (nodoAnt1 != null) nodoAnt1.Siguiente = nodo2;
                nodo1.Anterior = nodo2;
                if (nodoSig2 != null) nodoSig2.Anterior = nodo1;
            }
            else
            {
                nodoAnt1.Siguiente = nodo2;
                nodo2.Siguiente = nodoSig1;
                nodoAnt2.Siguiente = nodo1;
                nodo1.Siguiente = nodoSig2;
                nodo1.Anterior = nodoAnt2;
                nodo2.Anterior = nodoAnt1;
                if (nodoSig1 != null) nodoSig1.Anterior = nodo2;
                if (nodoSig2 != null) nodoSig2.Anterior = nodo1;
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
            return RetornaUltimoRecursiva(C.Siguiente);
        }
        public int Cantidad()
        {
            int rdo = 0;
            if(C.Siguiente!=null) rdo = CantidadRecursiva(C.Siguiente);
            return rdo; 
        }
        private int CantidadRecursiva(Nodo pNodo)
        {
            int rdo = 1;
            if (pNodo.Siguiente!=null) rdo+=CantidadRecursiva(pNodo.Siguiente);
            return rdo;
        }
        private Nodo? RetornaUltimoRecursiva(Nodo? pNodo)
        {
            Nodo? auxNodo = pNodo;
            if (auxNodo !=null)
            {
                if (auxNodo.Siguiente!=null) auxNodo = RetornaUltimoRecursiva(auxNodo.Siguiente);
            }
            return auxNodo;
        }

    }
}
