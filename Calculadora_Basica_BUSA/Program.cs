

/*

Propósito:
----------
- Implementar una calculadora básica con las operaciones suma, resta, multiplicación y división
 utilizando el ciclo de control While, el selector múltiple "switch/case" y control de excepciones
 con try/catch

*/


int opcion = -1;

float numero1 = 0, numero2 = 0, resultado = 0;

while (opcion != 0)
{
    Console.WriteLine("\n*********** Calculadora básica para dos números ***********");
    Console.WriteLine("Elija una opcion" +
        "\n\t1. Suma" +
        "\n\t2. Resta" +
        "\n\t3. Multiplicacion" +
        "\n\t4. Division" +
        "\n\t0. Salir");

    try
    {
        opcion = int.Parse(Console.ReadLine());

        if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4)
        {

            //Console.WriteLine("Ingrese el primer numero");
            //numero1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese el primer numero");
            //numero2 = float.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Suma
                    Console.WriteLine("***** Selecciono la opcion: Suma *****");

                    Console.WriteLine("Ingrese el primer numero");
                    numero1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el primer numero");
                    numero2 = float.Parse(Console.ReadLine());

                    resultado = numero1 + numero2;
                    break;

                case 2:
                    //Resta
                    Console.WriteLine("***** Selecciono la opcion: Resta *****");

                    Console.WriteLine("Ingrese el primer numero");
                    numero1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el primer numero");
                    numero2 = float.Parse(Console.ReadLine());

                    resultado = numero1 - numero2;
                    break;

                case 3:
                    //Multiplicacion
                    Console.WriteLine("***** Selecciono la opcion: Multiplicacion *****");

                    Console.WriteLine("Ingrese el primer numero");
                    numero1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el primer numero");
                    numero2 = float.Parse(Console.ReadLine());

                    resultado = numero1 * numero2;
                    break;

                case 4:
                    //Division
                    Console.WriteLine("***** Selecciono la opcion: Division *****");

                    Console.WriteLine("Ingrese el primer numero");
                    numero1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el primer numero");
                    numero2 = float.Parse(Console.ReadLine());

                    if (numero2 != 0)
                        resultado = numero1 / numero2;
                    break;
            }
            if (opcion == 4 && numero2 == 0)
                Console.WriteLine("No se puede dividir por cero");
            else
                Console.WriteLine("El resultado es: {0}", resultado);
                Console.WriteLine("--------------------------------------");
        }
        else
        {
            if (opcion != 0)
                Console.WriteLine("Ingresate un número inválido. Intenta nuevamente!\n");
        }
    }
    catch (FormatException error)
    {
        Console.WriteLine("Ingresaste un valor no numerico, intenta nuevamente.");
        Console.WriteLine(error.Message);
    }
}
Console.WriteLine("Ejecución Finalizada. Ha seleccionado salir.");