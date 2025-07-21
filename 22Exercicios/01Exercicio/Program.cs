/* 01
    Peça dois números inteiros, se forem iguais realize a soma, se forem diferentes realize a multiplicação
*/

Console.WriteLine("Informe o primeiro número: ");
int n1 = Convert.ToInt16(Console.ReadLine()); 
Console.WriteLine("Informe o segundo número: ");
int n2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(n1 == n2 ? (n1 + n2) : (n1 * n2));

/*if (n1 == n2)
{
    Console.WriteLine("N1 é igual a N2, então: " + n1 + " + " + n2);
    Console.WriteLine(n1 + n2);
}else
{
    Console.WriteLine("N1 é diferente de N2, então: " + n1 + " * " + n2);
    Console.WriteLine(n1 * n2);
}*/