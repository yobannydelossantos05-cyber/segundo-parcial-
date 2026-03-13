// See https://aka.ms/new-console-template for more information


Console.WriteLine("1- Suma");
Console.WriteLine("2- Resta");
Console.WriteLine("3- Multiplicar");
Console.WriteLine("4- Dividir");
Console.WriteLine("Elige una opcion");

int opcion = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el primer numero:");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero:");
double num2 = double.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Resultado: " + (num1 + num2));
        break;

    case 2:
        Console.WriteLine("Resultado: " + (num1 - num2));
        break;

    case 3:
        Console.WriteLine("Resultado: " + num1 * num2);
        break;

    case 4:

        if (num2 != 0)
        {
            Console.WriteLine("Resultado: " + (num1 / num2));
            break;
        }
        else
        {
            Console.WriteLine("Error, no se puede dividir entre cero");
        }
        break;

    default:
        Console.WriteLine("opcion invalida");
        break;
}
