Console.WriteLine("Informe um ano: ");
int ano = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(ano % 4 == 0 ? ano + " é um ano bissexto" : ano + " não é bissexto");