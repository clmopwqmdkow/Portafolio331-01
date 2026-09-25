using System;
namespace SE1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sesión 9: Examen
            //Sesión 10:Solución del examen
            //1. Proyecto en C#
            //2. Sintaxis
            //Tipo_de_dato indentificador_varibale;
            bool a;
            int numero;
            //3.Interpolacion
            //Combinación de datos dentro de una cadena
            a = true;
            numero = 10;
            Console.WriteLine($"Booleano; {a}");
            Console.WriteLine($"Numero: {numero}");
            // 4. Incrementos y decrementos
            int m = 0;
            int n = -1;
            m += 1;
            n -= 3;
            m -= 5;
            n += 9;
            // 5. Operdor resto
            int residuo = 40 % 16;
            Console.WriteLine($"residup: {residuo}");
            //6.Operadores aritmetico
            double operación = 0;
            operación = ((30 + 8 - 2) / 2) * -1;
            Console.WriteLine($"Operacion; {operación}");
            //Sesión 11: Solución del examen
            //7.Interruptores
            bool interruptor_1 = false;
            bool interruptor_2 = true;
            bool bombilla = false;
            if (interruptor_1 && interruptor_2)
            {
                bombilla = true;
            }
            else
            {
                bombilla = false;
            }
            Console.WriteLine($"Bonbilla: {bombilla}");
            //8. Asueto
            int dia = 16;
            string mes = "septiembre";
            if (dia == 16 && mes == "septiembre")
            {
                Console.WriteLine("Asueto");
            }
            else
            {
                Console.WriteLine("Sin definir");
            }
            //9.Resultado true
            bool resultado = (7 < 11) && 9 != 0;
            Console.WriteLine($"Expresión: {resultado}");

        }

    }
}
