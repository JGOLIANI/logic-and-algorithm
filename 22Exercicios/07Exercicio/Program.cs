/*
 * atividade 07
 * peça três numeros inteiros e veja qual deles é o menor
 * 
 */

Console.WriteLine("Informe o primeiro número: ");
int n1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Informe o segundo número: ");
int n2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Informe o terceiro número: ");
int n3 = Convert.ToInt16(Console.ReadLine());

if (n1 < n2 && n1 < n3)
{
    Console.WriteLine("O primeiro número é o menor entre os três números");
}
else if (n2 < n1 && n2 < n3)
{
    Console.WriteLine("O segundo número é o menor entre os três números");
}
else if (n3 < n1 && n3 < n2)
{
    Console.WriteLine("O terceiro número é o menor entre os três números");
}
else
{
    Console.WriteLine("Você está informando números iguais");
}