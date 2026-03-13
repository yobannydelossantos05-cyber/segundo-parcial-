// See https://aka.ms/new-console-template for more information

Console.WriteLine("------------Calculadora------------");
Console.WriteLine("1- suma: ");
Console.WriteLine("2- Resta: ");
Console.WriteLine("3- Multiplicacion: ");
Console.WriteLine("4- Division: ");

int opcion = int.Parse(Console.ReadLine());

Console.WriteLine("primera cantidad: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("segunda cantidad: ");
int num2 = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("La suma es: " + (num1 + num2));
        break;
    case 2:
        Console.WriteLine("La resa es: " + (num1 - num2));
        break;
    case 3:
        Console.WriteLine("La multiplicacion es: " + (num1 * num2));
        break;
    case 4:
        Console.WriteLine("La division es: " + (num1 / num2));
        break;


}