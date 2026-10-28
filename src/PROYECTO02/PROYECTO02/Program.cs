//Intercambio sin variable auxiliar
int a, b;
Console.Write("Escrbir el numero a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Escrbir el numero b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Los valores originales de a:{a} y b:{b}");

a = a+b;
b = a-b;
a = a - b;

Console.WriteLine($"Los valores intercambiados de a:{a} y b:{b}");