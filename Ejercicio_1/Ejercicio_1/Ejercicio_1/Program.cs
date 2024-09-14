internal class Program
{
    private static void Main(string[] args)
    {
        double sueldo,valor_v;
        int ventas;
        double beneficio = 0;
        double comision = 10;

        Console.Write("Ingrese su Sueldo Base: $");
        sueldo=Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese Cantidad de ventas: ");
        ventas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el valor de la venta: $");
        valor_v = Convert.ToDouble(Console.ReadLine());

        if (ventas==3 && valor_v >= 1000000)
        {
            beneficio = 100000;
            Console.Write($"Ganaste el Beneficio:{beneficio:C} ");
        }

    }
}