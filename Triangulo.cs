 using System;
  
public class TriangleAreaCalculator
{
    public static void Main(string[] args)
{
Console.WriteLine("--- Calculadora del Área de un Triángulo ---");
 double triangleBase;
         double triangleHeight;
 
         // Solicitar y validar la base
         while (true)
         {
             Console.Write("Introduce la longitud de la base del triángulo: ");
             string baseInput = Console.ReadLine();

             if (double.TryParse(baseInput, out triangleBase) && triangleBase > 0)
             {
                 break; // Salir del bucle si la entrada es válida
             }
             else
             {
                 Console.WriteLine("Entrada inválida. Por favor, introduce un número positivo para la base.");
             }
         }

         // Solicitar y validar la altura
         while (true)
         {
             Console.Write("Introduce la altura del triángulo: ");
             string heightInput = Console.ReadLine();

             if (double.TryParse(heightInput, out triangleHeight) && triangleHeight > 0)
             {
                 break; // Salir del bucle si la entrada es válida
             }
             else
             {
                 Console.WriteLine("Entrada inválida. Por favor, introduce un número positivo para la altura.");
             }
         }

         // Calcular el área
         double area = 0.5 * triangleBase * triangleHeight;

         // Mostrar el resultado
         Console.WriteLine($"\nLa base del triángulo es: {triangleBase}");
         Console.WriteLine($"La altura del triángulo es: {triangleHeight}");
         Console.WriteLine($"El área del triángulo es: {area}");

         Console.WriteLine("\nPresiona cualquier tecla para salir.");
         Console.ReadKey();
     }
    }
