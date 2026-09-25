using System;
//Espacio de nombres
namespace CS2
{
    //clase principal
        class Program
    {
        //Función principal
        static void Main(string[] args)
        {
            //Sesión 5: Tipos de datos
            //Sintaxis para declarar variables
            //tipo_de_dato identificador_variable;
            //1. Entero
            int a;
            //2. Cadena de texto
            string s;
            //3. Flotantes(precisión sencilla)
            float f;
            //3.2 Flotantes(precisión doble)
            double d;
            //4. Boleano (Lógico)
            bool b;
            //Inicializaciones
            a = 5;
            s = "Exactas";
            f = 8.5F;
            d = 9.5D;
            b = true;
            // Palabra reservadda: Identificador especial predefinido para el copilador.
            // Interpolación: Combinaciôn de datos dentro de una cadena
            //Impresiones
            Console.WriteLine($"Entero: {a}");
            Console.WriteLine($"Flotante(Precisión sencilla): {f}");
            Console.WriteLine($"Flotante (precisión doble): {d}");
            Console.WriteLine($"Cadena de texto: {s}");
            Console.WriteLine($"Boleano:{b}");
        }//Término de la función principal
    }//Término de la clase principal
}//Término del espacio de nombres
