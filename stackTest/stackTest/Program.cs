using stackTest.Clases;
using stackTest.Clases.clasesnum2;
using stackTest.Clases.Expresiones;
using stackTest.Clases.Lista_Enlazada;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace stackTest
{
    class Program
    {

        static void ejemploPilaLineal()//NUMERO CON PILA LINEAL
        {
            PilaLineal pila;
            int x;
            int CLAVE = -1;

            Console.WriteLine("Ingrese numeros, y para terminar -1");
            try
            {
                pila = new PilaLineal();
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if(x!= -1)
                    {
                        pila.insertar(x);
                    }
                } while (x != CLAVE);

                Console.WriteLine("ESTOS SON LOS ELEMENTOS DE LA PILA:");


                while (!pila.pilaVacia())
                {
                    x = (int)(pila.quitar());
                    Console.WriteLine($"elemento:{x}");
                }
                pila.insertar(900);
            }catch(Exception error)
            {
                Console.WriteLine("Error= " + error.Message);
            }
        }


        static void numerosPilaLista()//NUMERO CON PILA LIST <> 
        {
            PilaLista PilaL;
            int x;
            int CLAVE = -1;

            Console.WriteLine("Ingrese numeros, y para terminar -1");
            try
            {
                PilaL = new PilaLista();
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {
                        PilaL.insertar(x);
                    }
                } while (x != CLAVE);

                Console.WriteLine("ESTOS SON LOS ELEMENTOS DE LA PILA:");


                while (!PilaL.pilaVacia())
                {
                    x = (int)(PilaL.quitar());
                    Console.WriteLine($"elemento:{x}");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error= " + error.Message);
            }
        }

        static void numerosLista()//NUMERO CON LISTA ENLAZADA
        {
            listaenlazadapilalist pilaLista;
            int x;
            int CLAVE = -1;

            Console.WriteLine("Ingrese numeros, y para terminar -1");
            try
            {
                pilaLista = new listaenlazadapilalist();
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {
                        pilaLista.insertarprimero(x);
                    }
                } while (x != CLAVE);

                Console.WriteLine("ESTOS SON LOS ELEMENTOS DE LA PILA:");


                while (!pilaLista.ListaVacia())
                {
                    x = (int)(pilaLista.quitarchar());
                    Console.WriteLine($"elemento:{x}");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error= " + error.Message);
            }
        }/// 


        //PALINDROMOS
        static void pilindromo1()//usando PILA LINEAL
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            String pal;

            try
            {
                pilaChar = new PilaLineal();
                Console.WriteLine("Teclee una palabra para ver si es ");
                pal = Console.ReadLine();

                string remplazada = Regex.Replace(pal, @"\s", "");
                string convertida = remplazada.ToLower();
                Regex reg = new Regex("[^a-zA-Z0-9 ]");
                string textoNormalizado = convertida.Normalize(NormalizationForm.FormD);
                string textoSinAcentos = reg.Replace(textoNormalizado, "");

                //creamos la pila con los chars
                for (int i=0; i < textoSinAcentos.Length;)
                {
                    Char c;
                    c = textoSinAcentos[i++];
                    pilaChar.insertar(c);
                }

                //comprueva si es palindromo
                esPalindromo = true;
                for(int j = 0; esPalindromo&& !pilaChar.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaChar.quitarChar();
                    esPalindromo = textoSinAcentos[j++] == c;//evalua si la posicion es igual o no es igual

                }
                pilaChar.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {pal} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel, no es ");
                }

            }
            catch(Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }
        }


        static void pilindromo2()//usando PILA LISTA
        {
            PilaLista pilaLs;
            bool esPalindromo;
            String pal;

            try
            {
                pilaLs = new PilaLista();
                Console.WriteLine("Teclee una palabra para ver si es ");
                pal = Console.ReadLine();

                string remplazada = Regex.Replace(pal, @"\s", "");
                string convertida = remplazada.ToLower();
                Regex reg = new Regex("[^a-zA-Z0-9 ]");
                string textoNormalizado = convertida.Normalize(NormalizationForm.FormD);
                string textoSinAcentos = reg.Replace(textoNormalizado, "");

                //creamos la pila con los chars
                for (int i = 0; i < textoSinAcentos.Length;)
                {
                    Char c;
                    c = textoSinAcentos[i++];
                    pilaLs.insertar(c);
                }

                //comprueva si es palindromo
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaLs.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaLs.quitar();
                    esPalindromo = textoSinAcentos[j++] == c;//evalua si la posicion es igual o no es igual

                }
                pilaLs.limpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {pal} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel, no es ");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }
        }

        static void pilindromo3()//usando LISTA ENLAZADA APILADA
        {
            MyLista pilaLista;
            bool esPalindromo;
            String pal;

            try
            {
                pilaLista = new MyLista();
                Console.WriteLine("Teclee una palabra para ver si es ");
                pal = Console.ReadLine();

                string remplazada = Regex.Replace(pal, @"\s", "");
                string convertida = remplazada.ToLower();
                Regex reg = new Regex("[^a-zA-Z0-9 ]");
                string textoNormalizado = convertida.Normalize(NormalizationForm.FormD);
                string textoSinAcentos = reg.Replace(textoNormalizado, "");

                //creamos la pila con los chars
                for (int i = 0; i < textoSinAcentos.Length;)
                {
                    Char c;
                    c = textoSinAcentos[i++];
                    pilaLista.insertarprimero(c);
                }

                Console.WriteLine("INVERSA");
                pilaLista.imprimeTodosLosNodos();
                esPalindromo = true;
                for (int j = 0; esPalindromo && !pilaLista.ListaVacia();)
                {
                    Char c;
                    c = (Char)pilaLista.quitarchar();
                    esPalindromo = textoSinAcentos[j++] == c;//evalua si la posicion es igual o no es igual

                }
                pilaLista.limpiarLista();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {pal} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel, no es ");
                }

            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }
        }/// 
        //PALINDROMOS FIN



        static void EjemploPilaLista()
        {
            int a;
            PilaLista pl = new PilaLista();
            pl.insertar(1);
            pl.insertar(5);
            pl.insertar(16);
            pl.insertar(217);
            pl.insertar(41);
            pl.insertar(19);

            var xx = pl.quitar();
            while(!pl.pilaVacia())
            {
                a = (int)pl.quitar();
                Console.WriteLine("ESTOS SON LOS DATOS= " + a);
            }
            int pau;
            pau = 0;
        }

        static void EjemploPilaLLineal()
        {
            int x;
            PilaLineal pl = new PilaLineal();
            pl.insertar(1);
            pl.insertar(5);
            pl.insertar(16);
            pl.insertar(217);
            pl.insertar(41);
            pl.insertar(19);

            var xx = pl.quitar();
            while(!pl.pilaVacia())
            {
                x = (int)pl.quitar();
                Console.WriteLine("ELEMENTOS DE LA PILA= " + x);
            }
            int pau;
            pau = 0;
        }

        static void EjemploListaEnlazad()/////
        {
            listaenlazadapilalist pl = new listaenlazadapilalist();
            pl.insertarprimero(1);
            pl.insertarprimero(5);
            pl.insertarprimero(16);
            pl.insertarprimero(217);
            pl.insertarprimero(41);
            pl.insertarprimero(19);

            pl.imprimeTodosLosNodos();
           // var xx = pl.quitarchar();
            int pau;
            pau = 0;
        }

        static void expresiones()///
        {
            string expresion;
            Console.WriteLine("INGRESE LA EXPRESION QUE DESEA EVALUAR");
            expresion = Console.ReadLine();
            Console.WriteLine("EL RESULTADO ES " + Aritmetica.evaluar(expresion));
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // ejemploPilaLineal();
            //pilindromo();
            //EjemploPilaLLineal();
            int opcion;
            do
            {
                Console.WriteLine("Opciones:");
                Console.WriteLine("1. Ingresar n cantidad de numeros utilizando pilas y lista enlazada");
                Console.WriteLine("2. Verificar si una palabra es palindromo utilizando pilas y lista enlazada");
                Console.WriteLine("3. Ejemplo pilas y lista enlazadas");
                Console.WriteLine("4. Expreciones matematicas");
                Console.WriteLine("5. salir del programa");
                Console.WriteLine("Ingresa el numero de la opcion que deceas");
               
                
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        numerosLista();
                        break;
                    case 2:
                        pilindromo3();
                        break;
                    case 3:
                        EjemploListaEnlazad();
                        break;
                    case 4:
                        expresiones();
                        break;
                    
                }
                Console.ReadLine();
                Console.Clear();
            } while (opcion != 5);


        }
    }
}
