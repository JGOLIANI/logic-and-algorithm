/*
 * Peça diversos números inteiros, até que seja informado o número zero.
 * Quando sair da estrutura de repetição, exiba a soma dos valores informados.
 * Exemplo: 5, 6, 9, 3 e 0 = 23
 */

int numero = 0;
int soma = 0;

do
{
    Console.WriteLine("Digite um número: ");
    numero = Convert.ToInt16(Console.ReadLine());

    soma += numero;
}
while (numero != 0);

Console.WriteLine($"A soma dos numeros informados é: {soma}");