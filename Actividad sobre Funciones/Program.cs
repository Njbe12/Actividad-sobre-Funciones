using System;
using System.Linq;
namespace Traduccion_de_codigo__funciones_
{
    class Program
    {
        public static double pi=3.14; public static double result; public static string opc; public static int vr; public static int vb; public static int va;
        public static void Bienvenida(string borde){
            Console.Clear();
            System.Console.WriteLine(borde+"\n\t     PROGRAMA PARA GEOMETRIA \n"+borde);
            Console.WriteLine("¿Qué area desea Calcular? \n\n(C) Circulo. \n(R) Rectángulo. \n(T) triángulo. \n(S) Salir.\n");
        }
        public static void AC(double pi, string borde){
            Console.Clear();
            Console.WriteLine(borde+"\n\t  Calculo del area del circulo\n"+borde);
            Console.WriteLine("\nIngrese el Radio -> ");
            vr = Int32.Parse(Console.ReadLine());
            Double x= (Double) vr;
            result= pi*(x*x);
            System.Console.WriteLine("El area del circulo es: " + result);
            System.Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        public static void AR(double pi, string borde){
            Console.Clear();
            Console.WriteLine(borde+"\n\t  Calculo del area del rectangulo\n"+borde);
            Console.WriteLine("\nIngrese la Base -> ");
            vb = Int32.Parse(Console.ReadLine());
            Double x= (Double) vb;
            Console.WriteLine("Ingrese la Altura -> ");
            va = Int32.Parse(Console.ReadLine());
            Double y= (Double) va;
            result=vb*va;
            System.Console.WriteLine("El area del rectangulo es: " + result);
            System.Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        public static void AT(double pi, string borde){
            Console.Clear();
            Console.WriteLine(borde+"\n\t  Calculo del area del triangulo\n"+borde);
            Console.WriteLine("\nIngrese la Base -> ");
            vb = Int32.Parse(Console.ReadLine());
            Double x= (Double) vb;
            Console.WriteLine("Ingrese la Altura -> ");
            va = Int32.Parse(Console.ReadLine());
            Double y= (Double) va;
            result=(va*vb)/2;
            System.Console.WriteLine("El area del triangulo es: " + result);
            System.Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            string borde=string.Concat(Enumerable.Repeat("*", 50));
            Bienvenida(borde);
            while (opc != "S"){
            System.Console.WriteLine("Ingrese su opcion -> "); 
            opc=Console.ReadLine();
            System.Console.WriteLine();
            if (opc=="S" || opc=="s"){
                System.Console.WriteLine("\n\nGracias por usar el programa de cálculo geométrico\n\n"); 
                break;
            }else if(opc == "C" || opc=="c"){
                AC(pi,borde);
                Bienvenida(borde);
            }else if(opc=="R" || opc=="r"){
                AR(pi,borde);
                Bienvenida(borde);
            }else if(opc=="T" || opc=="t"){
                AT(pi,borde);
                Bienvenida(borde);
            }else {
                System.Console.WriteLine(borde+"\n\tError - Escoja una opción correcta\n"+borde);
                System.Console.WriteLine("\nPresione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                Bienvenida(borde);
            }
            }
        }
    }
}
