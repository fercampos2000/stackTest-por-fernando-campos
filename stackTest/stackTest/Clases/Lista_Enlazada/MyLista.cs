using System;
using System.Collections.Generic;
using System.Text;

namespace stackTest.Clases.Lista_Enlazada
{
    class MyLista
    {
        public Nodo primero;
        public Nodo ultimo;
        public int cima;

        public MyLista()
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
            Nodo aux = new Nodo(dato);
            aux.siguiente = primero;
            primero = aux;
            cima++;
        }

        public void limpiarLista()
        {
            cima = 0;
        }

        public object quitarchar()
        {
            char aux;
            if (ListaVacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }
            aux = (char)primero.elemento;
            primero = primero.siguiente;
            cima--;
            return aux;
        }

        public void imprimeTodosLosNodos()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine(actual.elemento);
                actual = actual.siguiente;
            }
        }

    }
}
