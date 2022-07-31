using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeControl_Clase02B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //- Función a ejecutar
            Funcion_SWITCH();

            //- Sirve para que la aplicación no se cierre
            Console.ReadKey();
        }
        
        //- FUNCIONES Y MÉTODOS
        static void Funcion_IF()
        {
            /*
             * EJERCICIO
             * Evaluar una empresa con base a la cantidad de empleados 
             * mostrar que categoria de empresa es
             * Se evaluarán 3 empresas
             * menos de 25 empleados, Pequeña empresa
             * de 25 a menos de 50, Mediana empresa
             * de 50 en adelante, Gran empresa
             */

            //- VARIABLES LOCALES E INICIALIZACIÓN
            //- categorías
            string categoria1 = "Pequeña empresa";
            string categoria2 = "Mediana empresa";
            string categoria3 = "Gran empresa";

            //- Cantidad de empleados por empresa
            int empleados_empresa1 = 0;
            int empleados_empresa2 = 0;
            int empleados_empresa3 = 0;

            //- SOLICITUD DE DATOS
            //- Solicitud de datos para empresa 1
            Console.Write("Digite la cantidad de empleados para la empresa 1: ");
            empleados_empresa1 = int.Parse(Console.ReadLine());

            //- Solicitud de datos para empresa 2
            Console.Write("Digite la cantidad de empleados para la empresa 2: ");
            empleados_empresa2 = int.Parse(Console.ReadLine());

            //- Solicitud de datos para empresa 3
            Console.Write("Digite la cantidad de empleados para la empresa 3: ");
            empleados_empresa3 = int.Parse(Console.ReadLine());

            //- EVALUACIÓN DE DATOS
            //- Evaluación de datos empresa 1
            if (empleados_empresa1 < 25 && empleados_empresa1 > 0)
            {
                if (empleados_empresa1 == 24)
                {
                    Console.WriteLine("La empresa #1 es una " + categoria1 
                        + ", y se encuentra a punto de subir de categoría."); 
                }
                else
                {
                    Console.WriteLine("La empresa #1 es una " + categoria1);
                }
            }
            else if (empleados_empresa1 >=25 && empleados_empresa1 < 50)
            {
                if (empleados_empresa1 == 49)
                {
                    Console.WriteLine("La empresa #1 es una " + categoria2
                        + ", y se encuentra a punto de subir de categoría.");
                }
                else
                {
                    Console.WriteLine("La empresa #1 es una " + categoria2);
                }
            }
            else if(empleados_empresa1 >= 50)
            {
                Console.WriteLine("La empresa #1 es una " + categoria3);
            }
            else
            {
                Console.WriteLine("Ingresaste un valor negativo o cero");
            }

            //- Evaluación de datos empresa 2
            if (empleados_empresa2 < 25 && empleados_empresa2 > 0)
            {
                if (empleados_empresa2 == 24)
                {
                    Console.WriteLine("La empresa #2 es una " + categoria1
                        + ", y se encuentra a punto de subir de categoría.");
                }
                else
                {
                    Console.WriteLine("La empresa #2 es una " + categoria1);
                }
            }
            else if (empleados_empresa2 >= 25 && empleados_empresa2 < 50)
            {
                if (empleados_empresa2 == 49)
                {
                    Console.WriteLine("La empresa #2 es una " + categoria2
                        + ", y se encuentra a punto de subir de categoría.");
                }
                else
                {
                    Console.WriteLine("La empresa #2 es una " + categoria2);
                }
            }
            else if (empleados_empresa2 >= 50)
            {
                Console.WriteLine("La empresa #2 es una " + categoria3);
            }
            else
            {
                Console.WriteLine("Ingresaste un valor negativo o cero");
            }

            //- Evaluación de datos empresa 3
            if (empleados_empresa3 < 25 && empleados_empresa3 > 0)
            {
                if (empleados_empresa3 == 24)
                {
                    Console.WriteLine("La empresa #3 es una " + categoria1
                        + ", y se encuentra a punto de subir de categoría.");
                }
                else
                {
                    Console.WriteLine("La empresa #3 es una " + categoria1);
                }
            }
            else if (empleados_empresa3 >= 25 && empleados_empresa3 < 50)
            {
                if (empleados_empresa1 == 49)
                {
                    Console.WriteLine("La empresa #3 es una " + categoria2
                        + ", y se encuentra a punto de subir de categoría.");
                }
                else
                {
                    Console.WriteLine("La empresa #3 es una " + categoria2);
                }
            }
            else if (empleados_empresa3 >= 50)
            {
                Console.WriteLine("La empresa #3 es una " + categoria3);
            }
            else
            {
                Console.WriteLine("Ingresaste un valor negativo o cero");
            }
        }

        static void Funcion_SWITCH()
        {
            /*
             *Mostrar un menú para poder realizar diferentes funcionalidades dentro de un programa
             *Evaluar la opción
             *Mostrar mensaje de error en caso de tomar una opción no válida o que no se encuentre dentro del menú
             */

            //- VARIABLE LOCALES E INICIALIZACIÓN
            int respuesta = 0;

            //- IMPRIMIR MENÚ
            Console.WriteLine("Menú de opciones" 
                + "\n[1] Decir Hola"
                + "\n[2] Decir Adiós"
                + "\n[3] Decir Hola y Adiós" 
                + "\n[4] Decir Hola, eres un pro");
            Console.Write("Digite su respuesta: ");
            //- Leer respuesta y parsear
            respuesta = int.Parse(Console.ReadLine());

            //- ESTRUCTURA DE SWITCH
            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Hola");
                    break;
                case 2:
                    Console.WriteLine("Adiós");
                    break;
                case 3:
                    Console.WriteLine("Hola y Adiós");
                    break;
                case 4:
                    Console.WriteLine("Hola, eres un pro");
                    break;
                default:
                    Console.WriteLine("Por favor, escoge una respuesta dentro del menú");
                    break;
            }
        }
    }
}
