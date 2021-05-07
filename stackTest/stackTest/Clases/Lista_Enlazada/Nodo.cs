using System;
using System.Collections.Generic;
using System.Text;

namespace stackTest.Clases.Lista_Enlazada
{
    class Nodo
    {
        public Object elemento;
        public Nodo siguiente;


        public Nodo(Object entrada)
        {
            this.elemento = entrada;
            this.siguiente = null;

        }

    }
}
