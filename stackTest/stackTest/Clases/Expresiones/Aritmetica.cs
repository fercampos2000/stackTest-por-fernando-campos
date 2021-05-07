using System;

namespace stackTest.Clases.Expresiones
{
    class Aritmetica
    {
        public static double evaluar(string infija)
        {
            String posfija = convertir(infija);
            Console.WriteLine("La expresion posfija es: " + posfija);
            return evaluarPosfija(posfija);
        }

        //convierto expresion a profija
        private static string convertir(string infija)//
         
        {
            string posfija = "";
            Pila_Aritmetia pila = new Pila_Aritmetia(49);
            for (int i = 0; i < infija.Length; i++)
            {
                char caracter = infija[i];
                if (esOperador(caracter))
                {
                    if (pila.pilavacia())
                    {
                        pila.apilar(caracter);
                    }
                    else
                    {
                        int pe = prioridadExpresion(caracter);
                        int pp = prioridadPila((char)pila.cimaPila());


                        if (pe > pp)
                        {
                            pila.apilar(caracter);

                        }
                        else
                        {
                            posfija += pila.desapilar();
                            pila.apilar(caracter);
                        }
                        


                    }
                }
                else
                {
                    posfija += caracter;
                }
            }                                               

            while (!pila.pilavacia())
            {
                posfija += pila.desapilar();
            }
            return posfija;

        }


        
        private static int prioridadExpresion(char operador)
        {
            if (operador == '^') return 4;
            if (operador == '*' || operador == '/') return 2;
            if (operador == '+' || operador == '-') return 1;
            if (operador == '(') return 5;
            return 0;
        }

       
        private static int prioridadPila(char operador)
        {
            if (operador == '^') return 3;
            if (operador == '*' || operador == '/') return 2;
            if (operador == '+' || operador == '-') return 1;
            if (operador == '(') return 0;
            return 0;
        }


      
        private static double evaluarPosfija(string posfija)
        {
            Pila_Aritmetia pila = new Pila_Aritmetia(100);

            for (int i = 0; i < posfija.Length; i++)
            {
                char valor = posfija[i];
                if (!esOperador(valor))
                {
                    double num = Convert.ToDouble(valor + "");
                    pila.apilar(num);
                }
                else
                {                                                   
                    double num2 = (double)pila.desapilar();
                    double num1 = (double)pila.desapilar();
                    double num3 = operacion(valor, num1, num2);
                    pila.apilar(num3);
                }
            }

            return (double)pila.cimaPila();
        }


       
        private static double operacion(char letras, double num1, double num2)
        {
            if (letras == '*') return num1 * num2;
            if (letras == '/') return num1 / num2;
            if (letras == '+') return num1 + num2;
            if (letras == '-') return num1 - num2;
            if (letras == '^') return Math.Pow(num1, num2);

            return 0;
        }


        //verifico si el que voy a insertar a la pila es un operador y retorno un true si no retorna un false caso que sea un numero
        private static bool esOperador(char caracter)
        {
            if (caracter == '*' || caracter == '/' || caracter == '+' || caracter == '-' || caracter == '(' || caracter == ')' || caracter == '^')
            {
                return true;
            }

            return false;

        }

    }
}
