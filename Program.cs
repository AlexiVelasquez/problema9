// See https://aka.ms/new-console-template for more information

//debe de ingresar 3 numeros primero para calcular

double num1, num2, num3;
double mayor= 0;


Console.WriteLine("Ingrese tres números enteros diferentes... :D");
Console.WriteLine("*********************************************");
num1 = double.Parse(Console.ReadLine());
num2 = double.Parse(Console.ReadLine());
num3 = double.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{

    mayor = num1;
    Console.WriteLine("El numero mayor es:"+ num1);

}

if (num2 > num1 && num2 > num3)
{

    mayor = num1;
    Console.WriteLine("El numero mayor es:" + num2);

}

if (num3 > num1 && num3 > num2)
{

    mayor = num1;
    Console.WriteLine("El numero mayor es:" + num3);

}