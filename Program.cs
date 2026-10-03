using System;

namespace RegistroBasico 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            // Pedimos el nombre del usuario para saludarlo bien
            Console.Write("Por favor, ingrese su nombre: ");
            string? nombre = Console.ReadLine();

            // Aquí solicitamos la edad. Ojo, necesitamos un número entero
            Console.Write("Ingrese su edad: ");
            
            // Usamos TryParse por si el usuario pone un texto en vez de un número, para que el programa no explote
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                // Validamos si ya es mayor de edad (18 años o más en RD)
                if (edad >= 18) 
                {
                    Console.WriteLine($"Hola {nombre}, eres mayor de edad.");
                } 
                else 
                {
                    Console.WriteLine($"Hola {nombre}, eres menor de edad.");
                }
                
                Console.WriteLine("\nImprimiendo los números del 1 al 10, como dice la práctica:");
                
                // Bucle for sencillo para contar del 1 al 10 y mostrarlos en consola
                for (int i = 1; i <= 10; i++) 
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                // Mensaje de error por si introducen un disparate en vez de un número
                Console.WriteLine("Oye, tenías que poner un número válido para la edad. Intenta correr el programa de nuevo.");
            }
        }
    }
}
