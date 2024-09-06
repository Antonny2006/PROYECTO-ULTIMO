using System;


class Proyecto
{
    static void Main()
    {
        Console.Write("Bienvenido, ingrese su nombre por favor: ");
        string usuario = Console.ReadLine();

        Console.WriteLine($"Bienvenido {usuario} a la tienda de Lemi : ");

        List<string> listaProductos = new List<string>();
        List<double> listaPrecios = new List<double>();

        int opcionPrincipal;
        do
        {

            Console.WriteLine("MENU");
            Console.WriteLine("Seleccione la categoría que le gustaría comprar: ");
            Console.WriteLine("1. Electrónica");
            Console.WriteLine("2. Aseo");
            Console.WriteLine("3. Refrescos");
            Console.WriteLine("3. Salir");
            Console.Write("Ingrese su opción: ");
            opcionPrincipal = int.Parse(Console.ReadLine());

            switch (opcionPrincipal)
            {
                case 1:

                    int opcionElectronica;
                    do
                    {
                        Console.WriteLine("Bienvenido a la Categoría de Electrónica");
                        Console.WriteLine("1. Tablet lps 1000");
                        Console.WriteLine("2. Smart Watch lps  700");
                        Console.WriteLine("3. Audífonos lps 150");
                        Console.WriteLine("4. Regresar al menú principal");
                        Console.Write("Seleccione un producto: ");
                        opcionElectronica = int.Parse(Console.ReadLine());

                        double precio = 0;
                        double impuesto = 0;

                        switch (opcionElectronica)
                        {
                            case 1:
                                precio = 1000;
                                impuesto = 0.18;
                                break;
                            case 2:
                                precio = 700;
                                impuesto = 0.15;
                                break;
                            case 3:
                                precio = 150;
                                impuesto = 0.10;
                                break;
                            case 4:

                                Console.WriteLine("Regresando al menú principal...");
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                                continue;
                        }

                        if (opcionElectronica >= 1 && opcionElectronica <= 3)
                        {
                            Console.Write("Ingrese la cantidad que desea comprar (máximo 100): ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 100)
                            {
                                Console.WriteLine("La cantidad no puede superar 100. Intente de nuevo.");
                                continue;
                            }

                            double precioConImpuesto = precio + (precio * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;


                            listaProductos.Add($"{(opcionElectronica == 1 ? "Tablet" : opcionElectronica == 2 ? "SmartWatch" : "Audífonos")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: ${precioConImpuesto:F2}");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: ${precioFinal:F2}");


                            Console.Write("¿Desea seguir comprando? (s/n): ");
                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "s")
                            {
                                Console.WriteLine("Generando factura final...");
                                MostrarFacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (opcionElectronica != 4);
                    break;

                case 2:

                    int opcionAseo;
                    do
                    {
                        Console.WriteLine("Categoría: Aseo");
                        Console.WriteLine("1. Jabon de lavar ropa lps 23");
                        Console.WriteLine("2. Jabon de baño lps 25");
                        Console.WriteLine("3. Ase lps 6");
                        Console.WriteLine("4. Regresar al menú principal");
                        Console.Write("Seleccione un producto: ");
                        opcionAseo = int.Parse(Console.ReadLine());

                        double precio = 0;
                        double impuesto = 0;

                        switch (opcionAseo)
                        {
                            case 1:
                                precio = 23;
                                impuesto = 0.05;
                                break;
                            case 2:
                                precio = 25;
                                impuesto = 0.07;
                                break;
                            case 3:
                                precio = 6;
                                impuesto = 0.08;
                                break;
                            case 4:

                                Console.WriteLine("Regresando al menú principal...");
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                                continue;
                        }

                        if (opcionAseo >= 1 && opcionAseo <= 3)
                        {
                            Console.Write("Ingrese la cantidad que desea comprar (máximo 100): ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 100)
                            {
                                Console.WriteLine("La cantidad no puede superar 100. Intente de nuevo.");
                                continue;
                            }

                            double precioConImpuesto = precio + (precio * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;

                            listaProductos.Add($"{(opcionAseo == 1 ? "Pan" : opcionAseo == 2 ? "Leche" : "Huevos")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: ${precioConImpuesto:F2}");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: ${precioFinal:F2}");

                            Console.Write("¿Desea seguir comprando? (s/n): ");
                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "s")
                            {
                                Console.WriteLine("Generando factura final...");
                                MostrarFacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (opcionAseo != 4);
                    break;

                case 3:

                    int opcionFrescos;
                    do
                    {
                        Console.WriteLine("Bienvenido a la Categoría de Refrescos");
                        Console.WriteLine("1. Coca Cola Portatil 22 lps");
                        Console.WriteLine("2. Uva 25 lps ");
                        Console.WriteLine("3. Pepsi 60 lps ");
                        Console.WriteLine("4. Regresar al menú principal");
                        Console.Write("Seleccione un producto: ");
                        opcionFrescos = int.Parse(Console.ReadLine());

                        double precio = 0;
                        double impuesto = 0;

                        switch (opcionFrescos)
                        {
                            case 1:
                                precio = 22;
                                impuesto = 0.18;
                                break;
                            case 2:
                                precio = 25;
                                impuesto = 0.05;
                                break;
                            case 3:
                                precio = 60;
                                impuesto = 0.6;
                                break;
                            case 4:

                                Console.WriteLine("Regresando al menú principal...");
                                break;
                            default:
                                Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                                continue;
                        }

                        if (opcionFrescos >= 1 && opcionFrescos <= 3)
                        {
                            Console.Write("Ingrese la cantidad que desea comprar (máximo 100): ");
                            int cantidad = int.Parse(Console.ReadLine());

                            if (cantidad > 100)
                            {
                                Console.WriteLine("La cantidad no puede superar 100. Intente de nuevo.");
                                continue;
                            }

                            double precioConImpuesto = precio + (precio * impuesto);
                            double descuento = CalcularDescuento(cantidad);
                            double precioFinal = (precioConImpuesto - (precioConImpuesto * descuento)) * cantidad;


                            listaProductos.Add($"{(opcionFrescos == 1 ? "Laptop" : opcionFrescos == 2 ? "Smartphone" : opcionFrescos == 3 ? "Audífonos " : "maricas")} x{cantidad}");
                            listaPrecios.Add(precioFinal);

                            Console.WriteLine($"Precio por unidad con impuesto: ${precioConImpuesto:F2}");
                            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                            Console.WriteLine($"Precio total por {cantidad} unidades: ${precioFinal:F2}");


                            Console.Write("¿Desea seguir comprando? (s/n): ");
                            string seguirComprando = Console.ReadLine().ToLower();
                            if (seguirComprando != "s")
                            {
                                Console.WriteLine("Generando factura final...");
                                MostrarFacturaFinal(listaProductos, listaPrecios);
                                return;
                            }
                        }

                    } while (opcionFrescos != 4);
                    break;

                case 4:

                    Console.WriteLine("Generando factura final...");
                    MostrarFacturaFinal(listaProductos, listaPrecios);
                    break;

                default:

                    Console.WriteLine("Opción inválida, por favor intente de nuevo.");
                    break;
            }

        } while (opcionPrincipal != 4);
    }


    static double CalcularDescuento(int cantidad)
    {
        if (cantidad >= 50)
        {
            return 0.15;
        }
        else if (cantidad >= 20)
        {
            return 0.10;
        }
        else if (cantidad >= 10)
        {
            return 0.05;
        }
        else
        {
            return 0;
        }
    }


    static void MostrarFacturaFinal(List<string> listaProductos, List<double> listaPrecios)
    {

        double total = 0;

        for (int i = 0; i < listaProductos.Count; i++)
        {
            Console.WriteLine($"{listaProductos[i]} - ${listaPrecios[i]:F2}");
            total += listaPrecios[i];
        }

        Console.WriteLine($"----------------------------------");
        Console.WriteLine($"Cantidad final : ${total:F2} gracias por su compra");

    }
}

