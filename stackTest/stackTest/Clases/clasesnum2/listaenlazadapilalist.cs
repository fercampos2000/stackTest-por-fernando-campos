using System;
using System.Collections.Generic;
using System.Text;

namespace stackTest.Clases.clasesnum2
{
    class listaenlazadapilalist
    {
        
            public Nodo2 primero;
            public Nodo2 ultimo;
            public int cima;

            public listaenlazadapilalist()
            {
                primero = null;
                ultimo = null;
                cima = 0;

            }
            public bool listallena()
            {
                return primero == null;
            }
            public bool ListaVacia()
            {
                if (primero == null)
                {
                    return (true);
                }
                else
                {
                    return (false);
                }
            }

            public void insertarprimero(object dato)
            {
            Nodo2 aux = new Nodo2(dato);
                aux.siguiente = primero;
                primero = aux;
                cima++;
            }

            public void limpiarLista()
            {
                cima = -1;
            }

            public object quitarchar()
            {
                Object aux;
                if (ListaVacia())
                {
                    throw new Exception("PILA VACIA NO HAY DATA");
                }
                aux = (Object)primero.elemento;
                primero = primero.siguiente;
                cima--;
                return aux;
            }

            public void imprimeTodosLosNodos()
            {
            Nodo2 actual = primero;
                while (actual != null)
                {
                    Console.WriteLine(actual.elemento);
                    actual = actual.siguiente;
                }
            }

        
    }
}
