
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
