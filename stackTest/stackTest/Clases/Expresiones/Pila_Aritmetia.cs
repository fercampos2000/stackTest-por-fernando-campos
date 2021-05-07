using System;
using System.Collections.Generic;
using System.Text;

namespace stackTest.Clases.Expresiones
{
    class Pila_Aritmetia//ES LO MISMO A LA PILA LINEAL DADA EN CLASE
    {
        private int tamaño;
        private int cima;
        private Object[] Pila;


        public Pila_Aritmetia(int n)
        {
            this.tamaño = n;
            cima = 0;
            Pila = new Object[tamaño];
        }

        public bool pilavacia()
        {
            return cima == 0;
        }

        public bool pilallena()
        {
            return cima == tamaño;
        }


        public void apilar(Object elemento)
        {
            if (!pilallena())
            {
                cima++;
                Pila[cima] = elemento;
            }

        }


        public void limpiarPila()
        {
            cima = 0;
        }

        //retorna un tipo char

        public object desapilar()
        {
            Object aux;
            if (pilavacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }
            aux = (Object)Pila[cima];
            cima--;
            return aux;
        }


        //operación de acceso a la pila

        public Object cimaPila()
        {
            if (pilavacia())
            {
                throw new Exception("Pila vacia");
            }
            return Pila[cima];
        }

    }
}
