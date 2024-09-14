internal class Program
{
    private static void Main(string[] args)
    {
        double sueldo,valor_v,valor_TotalV;
        int Numventas;
        double beneficio = 0;
        double comision = 10;

        Console.Write("Ingrese su Sueldo Base: $");
        sueldo=Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese Cantidad de ventas: ");
        Numventas = Convert.ToInt32(Console.ReadLine());


        if (Numventas < 0)
        {
            Console.Write("La cantidad de ventas no puede ser negativa, ingrese nuevamente las ventas realizadas: ");
            Numventas = Convert.ToInt32(Console.ReadLine());

        }
        else if (Numventas > 3)
        {
            Console.Write("El Máximo de ventas posibles a realizar para acceder al beneficio es de 3");
            beneficio = 100000;
        }
        else if (Numventas == 3)
        {

            beneficio = 100000;
            Console.Write($"Por la cantidad de ventas realizadas la empresa te dara un beneficio de: ${beneficio}");
        }

        Console.Write("Ingrese el valor de la venta: $");
        valor_v = Convert.ToDouble(Console.ReadLine());

    }
}