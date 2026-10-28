//Intercambio con variable auxiliar
//Definir las variables
int a, b,c;

Console.Write("Escribe el valor del numero a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Escribe el valor del numero b: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"los numeros originales son a:{a} y el numero b es:{b}");

c = a;
a = b;
b = c;

Console.WriteLine($"Los numeros intercambiados son a:{a} y el numero b es:{b}");