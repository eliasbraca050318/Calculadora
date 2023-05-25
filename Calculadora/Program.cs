using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char operador;

            //Enviamos un mensaje de bienvenida y una descripcion del programa

            Console.WriteLine("Bienvenido a Nuestro programa");
            Console.WriteLine("Este Programa Permite Operaciones Basicas Sobre Dos Numero");
            Console.WriteLine("----------------------");

            Console.WriteLine("De el valor del primer Numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("De el valor del Segundo Numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indique la Operacion(*,+,-,/)");
            operador = char.Parse(Console.ReadLine());
            /*identificamos el tipo de operacion a realizar haciendo uso
            del condicional IF*/

            if(operador == '*')
            {
                Console.WriteLine("la Multiplicacion es de: " + (num1 * num2));
            }

            if (operador == '/')
            {
                Console.WriteLine("la Division es de: " + (num1 / num2));
            }

            if (operador == '+')
            {
                Console.WriteLine("la Suma es de: " + (num1 + num2));
            }

            if (operador == '-')
            {
                Console.WriteLine("la Resta es de: " + (num1 - num2));
            }

            Console.ReadLine();

            switch (operador)
            {
                case '*':
                    Console.WriteLine("la Multiplicacion es de: " + (num1 * num2));
                    break;

                case '/':
                    Console.WriteLine("la Division es de: " + (num1 / num2));
                    break;

                case '+':
                    Console.WriteLine("la Suma es de: " + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("la Resta es de: " + (num1 - num2));
                    break;

                default: Console.WriteLine("No es Una Opcion Valida");
                    break;
            }
            Console.ReadLine();
        }
    }
}
