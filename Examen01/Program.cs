// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string DeterminarSigno(int numero)
{
    if (numero > 0)
    {
        return "postivo";
    }
    else if (numero < 0)
    {
        return "negativo";
    }
    else
    {
        return "cero";
    }

}

void MostrarMensajeSegunDia(string dia)
{
    switch (dia.ToLower())
    {
        case "lunes":
            Console.WriteLine("Hoy es lunes. ¡Ánimo, comienza la semana!");
            break;
        case "martes":
            Console.WriteLine("Hoy es martes. ¡A por el martes!");
            break;
        case "miércoles":
            Console.WriteLine("Hoy es miércoles. ¡Mitad de semana!");
            break;
        case "jueves":
            Console.WriteLine("Hoy es jueves. ¡Casi viernes!");
            break;
        case "viernes":
            Console.WriteLine("Hoy es viernes. ¡Por fin llegó el viernes!");
            break;
        case "sábado":
            Console.WriteLine("Hoy es sábado. ¡Disfruta el fin de semana!");
            break;
        case "domingo":
            Console.WriteLine("Hoy es domingo. ¡Día de descanso!");
            break;
        default:
            Console.WriteLine("No es un día válido. Por favor, ingresa un día de la semana válido.");
            break;
    }
}

int CalcularSumaNaturales(int n)
{
    int suma = 0;

    for (int i = 1; i <= n; i++)
    {
        suma += i;
    }

    return suma;
}

void ImprimirNumeros(int numero)
{
    Console.WriteLine("Números del 1 al " + numero + ":");

    for (int i = 1; i <= numero; i++)
    {
        Console.Write(i + " ");
    }
}

double CalcularAreaCirculo(double radio)
{
    return Math.PI * radio * radio;
}

void MostrarElementosArreglo(int[] arreglo)
{
    Console.WriteLine("Elementos del arreglo:");

    foreach (int elemento in arreglo)
    {
        Console.Write(elemento + " ");
    }
}

void MostrarNombres(List<string> nombres)
{
    Console.WriteLine("Nombres de personas:");

    foreach (string nombre in nombres)
    {
        Console.WriteLine(nombre);
    }
}

int opcion = 0;

do
{
    Console.WriteLine("Menú de Examen:");
    Console.WriteLine("1. Determinar si un número ingresado por el usuario es positivo, negativo o cero. ");
    Console.WriteLine("2. Imprimir un mensaje según el día de la semana ingresado por el usuario.");
    Console.WriteLine("3. Calcular la suma de los primeros 100 números naturales.");
    Console.WriteLine("4. Imprimir todos los números desde 1 hasta el número ingresado por el usuario.");
    Console.WriteLine("5. Calcular el área de un círculo utilizando el radio ingresado por el usuario.");
    Console.WriteLine("6. Mostrar los elementos de un arreglo unidimensional predefinido.");
    Console.WriteLine("7. Mostrar nombres de personas almacenados en una lista predefinida.");
    Console.WriteLine("8. Salir");
    Console.Write("Seleccione una opción: ");

    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ha seleccionado la Opción 1.");
                Console.WriteLine("Ingresa un número:");
                int numero = Convert.ToInt32(Console.ReadLine());

                string resultado = DeterminarSigno(numero);

                Console.WriteLine("El número ingresado es: " + resultado);
                break;
            case 2:
                Console.WriteLine("Ha seleccionado la Opción 2.");
                Console.Write("Ingresa un día de la semana: ");
                string diaSemana = Console.ReadLine();

                MostrarMensajeSegunDia(diaSemana);

                break;
            case 3:
                Console.WriteLine("Ha seleccionado la Opción 3.");
                int suma = CalcularSumaNaturales(100);

                Console.WriteLine("La suma de los primeros 100 números naturales es: " + suma);

                break;
            case 4:
                Console.WriteLine("Ha seleccionado la Opción 4.");
                Console.WriteLine("Ingresa un número:");
                int num = Convert.ToInt32(Console.ReadLine());

                ImprimirNumeros(num);

                break;
            case 5:
                Console.WriteLine("Ha seleccionado la Opción 5.");
                Console.WriteLine("Ingresa el radio del círculo:");
                double radio = Convert.ToDouble(Console.ReadLine());

                double area = CalcularAreaCirculo(radio);

                Console.WriteLine("El área del círculo con radio " + radio + " es: " + area);

                break;
            case 6:
                Console.WriteLine("Ha seleccionado la Opción 6.");
                int[] arreglo = { 100, 220, 330, 440, 550 };

                MostrarElementosArreglo(arreglo);

                break;
            case 7:
                Console.WriteLine("Ha seleccionado la Opción 7.");
                List<string> nombres = new List<string> { "Renzo", "Kely", "Fernando", "Ana", "Luisa" };

                MostrarNombres(nombres);

                break;
            case 8:
                Console.WriteLine("Saliendo del programa...");

                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
    }

    Console.WriteLine();
} while (opcion != 8);