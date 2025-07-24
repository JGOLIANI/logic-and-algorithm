Console.WriteLine("Informe a primeira nota: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe a segunda nota: ");
double n2 = Convert.ToDouble(Console.ReadLine());

double average = (n1 + n2) / 2;
Console.WriteLine($"A média é: {average}");

if (average >= 7)
{
    Console.WriteLine("Aprovado");

}else if (average >= 5)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}