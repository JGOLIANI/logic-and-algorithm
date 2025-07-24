Console.WriteLine("Informe um dia: ");
int dia = Convert.ToInt16(Console.ReadLine());

if(dia == 7 || dia == 14 || dia == 21 || dia == 28)
{
    Console.WriteLine($"O dia {dia} é uma segunda-feira do mês de julho");
}
else if(dia == 1 || dia == 8 || dia == 15 || dia == 22 || dia == 29)
{
    Console.WriteLine($"O dia {dia} é uma terça-feira do mês de julho");

}
else if(dia == 2 || dia == 9 || dia == 16 || dia == 23 || dia == 30)
{
    Console.WriteLine($"O dia {dia} é uma quarta-feira do mês de julho");

}
else if(dia == 3 || dia == 10 || dia == 17 || dia == 24 || dia == 31)
{
    Console.WriteLine($"O dia {dia} é uma quinta-feira do mês de julho");

}
else if(dia == 4 || dia == 11 || dia == 18 || dia == 25)
{
    Console.WriteLine($"O dia {dia} é uma sexta-feira do mês de julho");

}
else if(dia == 5 || dia == 12 || dia == 19 || dia == 26)
{
    Console.WriteLine($"O dia {dia} é um sábado do mês de julho");

}
else if(dia == 6 || dia == 13 || dia == 20 || dia == 27)
{
    Console.WriteLine($"O dia {dia} é um domingo do mês de julho");

}
else
{
    Console.WriteLine("Dia inválido!");
}

