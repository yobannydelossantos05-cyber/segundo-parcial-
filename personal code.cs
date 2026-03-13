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

/*
//............................................
Console.WriteLine("Ingrese la calificacion");
int calificacion = int.Parse(Console.ReadLine());

if (calificacion < 0 || calificacion > 100)
{
    Console.WriteLine("ERROR: El valor esta fuera del rango (0-100)");

}
else if (calificacion >= 90 && calificacion <= 100)
{
    Console.WriteLine("Excelente");
}
else if (calificacion >= 80 && calificacion <= 89)
{
    Console.WriteLine("Muy bien");
}
else if (calificacion >= 70 && calificacion <= 79)
{
    Console.WriteLine("Aprobado");
}

else if (calificacion < 70)
{
    Console.WriteLine("Reprobado");
}



//............................................
Console.WriteLine("Ingrese un numero");
int num = int.Parse(Console.ReadLine());
if (num % 2 ==0 )
{
    Console.WriteLine("Es par");
}
else
{
    Console.WriteLine("Es Impar");
}


//----------------------------------------------
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Los pares son: ");
for (int i = 2; i <= num; i += 2)
{
    Console.WriteLine(i);
}


//----------------------------------------------
Console.WriteLine("Ingrese el primer numero");
int num1= int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer numero");
int num3 = int.Parse(Console.ReadLine());

if (num1 >= num2 && num1 >= num3)
{
    Console.WriteLine("El mayor es: " + num1);
}
else if (num2 >= num1 && num2 >= num3)
{
    Console.WriteLine("El mayor es: " + num2);
}
else if (num3 >= num1 && num3 >= num2)
{
    Console.WriteLine("El Mayor es: " + num3);
}


//----------------------------------------------
Console.WriteLine("Ingresa un numero para hacer su tabla");
int num = int.Parse(Console.ReadLine());
for (int i = 1; i <= 10; i++) 
{
    Console.WriteLine(num + " x " + i + "= " + (num * i));

}


//----------------------------------------------
for (int i = 1; i<= 10; i++)
{
    Console.WriteLine(i);
}


//----------------------------------------------
Console.WriteLine("Ingrese la calificacion");
int calificacion = int.Parse(Console.ReadLine());
if (calificacion >= 70 && calificacion <= 100)
{
    Console.WriteLine("Aprovado");
}
else if (calificacion >= 100)
{
    Console.WriteLine("Esta fuera del rango 0-100");
}
else
{
    Console.WriteLine("Reprobado");
}


//----------------------------------------------
Console.Write("Ingresa un numero: ");
int num = int.Parse(Console.ReadLine());
if (num == 0)
{
   Console.Write("cero");
}
else if (num>=0)
{   
  Console.Write("positivo");
}
else
{
   Console.Write("Negativo");
}


//----------------------------------------------
Console.WriteLine("Ingresa tu edad");
int edad = int.Parse(Console.ReadLine());
int total = edad+10 ;
Console.WriteLine("Tu edad en 10 años sera: " + total);


//............................................
Console.WriteLine("ingrese el nombre");
string nombre= Console.ReadLine();
Console.WriteLine("mi nombre es: " + nombre);


//............................................
Console.WriteLine("INGRESE UN VALOR");
int num1= int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE otro valor");
int num2 = int.Parse(Console.ReadLine());
int Suma = num1 + num2;
Console.WriteLine("El valor de la suma es: " + Suma);

*/

