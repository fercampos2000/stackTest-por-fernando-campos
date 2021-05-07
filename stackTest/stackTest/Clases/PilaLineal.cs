using System;
using System.Collections.Generic;
using System.Text;

namespace stackTest.Clases
{
    class PilaLineal
    {
        private static int TAMPILA = 49;
        private int cima;
        private Object[] listaPila;



        public PilaLineal() {
            cima = -1;//CONDICION DE PILA VACIA.
            listaPila = new Object[TAMPILA];

        }

        public bool pilaLlena()
        {
            return cima == TAMPILA - 1;
        }

        //OPERACIONES QUE MODIFICAN LA PILA
        public void insertar(Object elemento)
        {
            if (pilaLlena())
            {
                throw new Exception("Desbordamiento de pila Stack Overflow");
            }
            //incrementar puntero cima y vamos a insertar el elemento
            cima++;
            listaPila[cima] = elemento;

        }

        public bool pilaVacia()
        {
            return cima == -1;
        }

        //retorna un tipo char
        public Object quitarChar()
        {
            char aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia, no hay datos");

            }
            aux = (char)listaPila[cima];
            cima--;
            return aux;

        }

        //extraer elemento de la pila (pop)

        public Object quitar()
        {
            int aux;
            if (pilaVacia())
            {
                throw new Exception("La Pila esta vacia, no se puede sacar");
            }
            //guardar el elemento en la cima
            aux = (int)listaPila[cima];
            //decrementar el valor de cima y retornar elemento
            cima--;
            return aux;
        }

        public void limpiarPila()
        {
            cima = -1;
        }
        //operacion de acceso a la pila
        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");

            }
            return listaPila[cima];

        }
    }
}
