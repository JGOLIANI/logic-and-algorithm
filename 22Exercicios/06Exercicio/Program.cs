/* Atividade 06
 * 
 * Peça um numero inteiro, retorne se ele é um positivo, neutro ou negativo.
 * 
 * Ex:
 * -5: Negativo
 * 34: Positivo
 * 0: Neutro
 */

Console.WriteLine("Informe um número: ");
int numero = Convert.ToInt16(Console.ReadLine());

if (numero < 0)
{
    Console.WriteLine($"O numero {numero} é negativo");
}
else if (numero > 0)
{
    Console.WriteLine($"O numero {numero} é positivo");
}
else
{
    Console.WriteLine($"O numero {numero} é neutro");
}