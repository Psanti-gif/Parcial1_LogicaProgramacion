/*
 * Escriba un programa que pida los coeficientes de una ecuación de primer grado (a x + b = 0) y muestre la solución.
Una ecuación de primer grado puede no tener solución, tener una solución única, o que todos los números sean solución. La fórmula de las soluciones es x = -b / a
 */
class Program
{
    static void Main()
    {
        double a, b;
        double x;
        Console.Write("Introduce el coeficiente a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el coeficiente b: ");
        b = Convert.ToDouble(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Todos los números son solución.");
            }
            else
            {
                Console.WriteLine("La ecuación no tiene solución.");
            }
        }
        else
        {
            x = -b / a;
            Console.WriteLine($"La solución es: x = {x}");
        }

    }
}
