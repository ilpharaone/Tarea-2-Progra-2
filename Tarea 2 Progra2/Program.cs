using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_Progra2
{
    internal class Program
    {

        public static void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1");

            float precio = 0f;
            int cantidad = 0;
            float total = 0f;
            Console.WriteLine("Cual es el precio de la camisa");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1)
            {
                Console.WriteLine($"Total a pagar: {precio}");
            }
            if (cantidad > 1 && cantidad < 6)
            {
                total = (cantidad * precio) * 0.15f;
                total = (cantidad * precio) - total;
                Console.WriteLine($"Total a pagar: {total} con descuento de 15% ");
            }
            if (cantidad > 6)
            {
                total = (cantidad * precio) * 0.20f;
                total = (cantidad * precio) - total;
                Console.WriteLine($"Total a pagar: {total} con descuento de 20% ");
            }
        }
    
        

        public static void Ejercicio2()
        {
            Console.WriteLine("Ejercicio 2");
            int n ;
            Console.WriteLine("Ingrese el numero de estudiantes");
            n = int.Parse(Console.ReadLine());
            float[] quices = new float[3];
            float[] tarea = new float[3]; 
            float[] examen = new float[3];
            string[] Estudiantes = new string[n];
            float[] promedio = new float[n];
            float totalq = 0;
            float totale = 0;
            float totalt = 0;
            

            for (int i = 0; i < Estudiantes.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante");
                Estudiantes[i] = Console.ReadLine();
                for (int j = 0; j <quices.Length; j++)
                {
                    Console.WriteLine("Ingrese la nota del quiz: ");
                    quices[j] = float.Parse(Console.ReadLine());
                    totalq = totalq + quices[j];
                    Console.WriteLine(totalq);
                }
                totalq = totalq / quices.Length * 0.2f ;
                Console.WriteLine(totalq);
                for (int k = 0; k < quices.Length; k++)
                {
                    Console.WriteLine("Ingrese la nota del examen: ");
                    examen[k] = float.Parse(Console.ReadLine());
                    totale = totale + examen[k];
                }
                totale = totale / examen.Length * 0.45f;
                for (int l = 0;  l< quices.Length; l++)
                {
                    Console.WriteLine("Ingrese la nota de la tarea: ");
                    tarea[l] = float.Parse(Console.ReadLine());
                    totalt = totalt + tarea[l];
                }
                totalt = totalt / tarea.Length * 0.3f;

                Console.Clear();
                promedio[i]= totalq + totale + totalt;
            }

            for (int i = 0; i < promedio.Length; i++)
            {
                if (promedio[i]>=70)
                {
                    Console.WriteLine("El estudiante "+Estudiantes[i]+" tiene "+totalq+" de quices, "+ totalt+"de tareas y "+totale+" de examenes, para un total de "+promedio[i]+" y esta aprobado");
                }
                else if (promedio[i]<70 && promedio[i]>=50)
                {
                    Console.WriteLine("El estudiante " + Estudiantes[i] + " tiene " + totalq + " de quices, " + totalt + "de tareas y " + totale + " de examenes, para un total de " + promedio[i] + " y esta aplazado");
                }
                else
                {
                    Console.WriteLine("El estudiante " + Estudiantes[i] + " tiene " + totalq + " de quices, " + totalt + "de tareas y " + totale + " de examenes, para un total de " + promedio[i] + " y esta reprobado");
                }
            }


        }

        public static void Ejercicio3()
        {
            Console.WriteLine("Ejercicio 3");
            int n;
            Console.WriteLine("Digite cuantos articulos va a comprar");
            n = int.Parse(Console.ReadLine());
            if (n<10)
            {
                n= n * 20;
                Console.WriteLine("Debe de pagar: "+n);
            }
            else
            {
                n = n * 10;
                Console.WriteLine("Debe de pagar: " + n);

            }
        }
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1- Ejercicio 1");
                Console.WriteLine("2- Ejercicio 2");
                Console.WriteLine("3- Ejercicio 3");
                Console.WriteLine("4- Salir");
                Console.WriteLine(" Digite una opcion");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Ejercicio1(); break;
                    case 2: Ejercicio2(); break;
                    case 3: Ejercicio3(); break;
                    default:
                        break;


                }
            } while (opcion != 4);
        }
    }
}
