internal class Program
{
    private static void Main(string[] args)
    {
        double sueldo, valor_v1, valor_v2, valor_v3, valor_TotalV,dinero_com,prom_com,sueldo_total;
        int Numventas;
        double beneficio = 0;
        const float comision = 10;

        Console.Write("Ingrese su Sueldo Base: $");
        sueldo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese Cantidad de ventas: ");
        Numventas = Convert.ToInt32(Console.ReadLine());

        if (Numventas == 3)
        {
            beneficio = 100000;
            Console.Write("Ingrese el valor de la primer venta: $");
            valor_v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Ingrese el valor de la segunda venta: $");
            valor_v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Ingrese el valor de la tercera venta: $");
            valor_v3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            valor_TotalV = valor_v1 + valor_v2 + valor_v3;
            Console.WriteLine($"El valor total de las ventas ha sido de: {valor_TotalV} ");
            Console.WriteLine(" ");

            dinero_com =( comision * (valor_v1) + comision * (valor_v2) + comision * (valor_v3))/100;
            Console.WriteLine($"El dinero obtenido por comisiones fue de: {dinero_com}");
            Console.WriteLine(" ");

            if (comision * (valor_v1) > comision * (valor_v2) && comision * (valor_v1) > comision * (valor_v3)) {
                Console.WriteLine(" ");
                Console.WriteLine("La Venta con mayor comision fue la primera con un valor total de comision a: " + comision * (valor_v1)/100);
                Console.WriteLine(" ");
            }
            else if (comision * (valor_v2) > comision * (valor_v1) && comision * (valor_v2) > comision * (valor_v3))
            {
                Console.WriteLine(" ");
                Console.WriteLine("La Venta con mayor comision fue la segunda con un valor total de comision a: " + comision * (valor_v2) / 100);
                Console.WriteLine(" ");
            }
            else if (comision * (valor_v3) > comision * (valor_v1) && comision * (valor_v3) > comision * (valor_v2))
            {
                Console.WriteLine(" ");
                Console.WriteLine("La Venta con mayor comision fue la tercera con un valor total de comision a : " + comision * (valor_v3) / 100);
                Console.WriteLine(" ");
            }


            prom_com = comision * (valor_v1) + comision * (valor_v2) + comision * (valor_v3) / 3;
            Console.WriteLine($"El promedio de las comisiones fue de: {prom_com} ");

            if (valor_TotalV >= 1000000) 
            {
                Console.WriteLine(" ");
                Console.Write($"Eres beneficiario al completar en las tres ventas un total de: {valor_TotalV} ");
                Console.WriteLine(" ");

                Console.WriteLine(" ");
                sueldo_total = valor_TotalV + dinero_com + beneficio;
                Console.Write($"Tu Dinero total seria de: {sueldo_total}");
                Console.WriteLine(" ");

            }


        }
        else if (Numventas == 2)
        {
            Console.Write("Ingrese el valor de la primer venta: $");
            valor_v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Ingrese el valor de la segunda venta: $");
            valor_v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            valor_TotalV = valor_v1 + valor_v2;
            Console.WriteLine($"El valor total de las ventas ha sido de: {valor_TotalV} ");
            Console.WriteLine(" ");

            dinero_com = (comision * (valor_v1) + comision * (valor_v2))/100;
            Console.Write($"El dinero obtenido por comisiones fue de: {dinero_com}");
            Console.WriteLine(" ");

            Console.WriteLine(" ");
            prom_com = comision * (valor_v1) + comision * (valor_v2) / 2;
            Console.WriteLine($"El promedio de las comisiones fue de: {prom_com} ");

            if (comision * (valor_v1) > comision * (valor_v2))
            {
                Console.WriteLine(" ");
                Console.WriteLine("La Venta con mayor comision fue la primera con un valor total a comision a: " + comision * (valor_v1) / 100);
                Console.WriteLine(" ");
            }
            else if (comision * (valor_v2) > comision * (valor_v1))
            {
                Console.WriteLine(" ");
                Console.WriteLine("La Venta con mayor comision fue la segunda con un valor total de comision a: " + comision * (valor_v2) / 100);
                Console.WriteLine(" ");
            }

            sueldo_total = valor_TotalV + dinero_com;
            Console.Write($"Tu Dinero total seria de: {sueldo_total}");
            Console.WriteLine(" ");

        }
        else if (Numventas == 1)
        {
            Console.Write("Ingrese el valor de la unica venta: $");
            valor_v1 = Convert.ToDouble(Console.ReadLine());

            valor_TotalV = valor_v1;
            Console.WriteLine($"El valor total de las venta ha sido de: {valor_TotalV} ");

            Console.WriteLine(" ");
            dinero_com = (comision * (valor_v1))/100;
            Console.WriteLine($"El dinero obtenido por comisiones fue de: {dinero_com}");
            Console.WriteLine(" ");

            Console.WriteLine($"La Comisión fue de: {dinero_com}");
            Console.WriteLine(" ");

            prom_com = comision * (valor_v1);
            Console.WriteLine($"El promedio de las comisiones fue de: {prom_com} ");

            Console.WriteLine(" ");
            sueldo_total = valor_TotalV + dinero_com;
            Console.Write($"Tu Dinero total seria de: {sueldo_total}");
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine("Error al Ingresar Cantidad");
        }

        
    }
}