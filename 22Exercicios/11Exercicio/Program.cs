/*
 * Peça dois números, em seguida exiba os valores entre os números.
 * 
 * Exemplo: Se informado 3 e 6 o retorno será 3 4 5 6
 */
Console.WriteLine("Informe o primeiro número: ");
int n1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Informe o segundo número: ");
int n2 = Convert.ToInt16(Console.ReadLine());
do
{
    Console.WriteLine(n1);
    n1++;
}
while (n1 <= n2);