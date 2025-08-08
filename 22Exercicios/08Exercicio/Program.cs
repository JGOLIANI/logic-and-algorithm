/*
 * Atividade 08
 * 
 * Peça três lados de um triangulo e retorne o seu tipo:
 * 
 * Equilátero: todos os lados congruentes;
 * Isósceles: dois lados congruentes;
 * Escaleno: todos os lados distintos;
 * 
 */

Console.WriteLine("Informe a medida do primeiro lado do triangulo: ");
int l1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Informe a medida do segundo lado do triangulo: ");
int l2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Informe a medida do terceiro lado do triangulo: ");
int l3 = Convert.ToInt16(Console.ReadLine());

if (l1 == l2 && l2 == l3)
{
    Console.WriteLine("O triangulo é Equilátero");
}
else if (l1 == l3 || l3 == l2 || l2 == l1)
{
    Console.WriteLine("O triangulo é Isósceles");
}
else
{
    Console.WriteLine("O triangulo é Escaleno");
}