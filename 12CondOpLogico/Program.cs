double value = 500;
string payment = "cash";

if (value >= 500 && payment == "cash")
{
    Console.WriteLine($"You received a 10% discount, your total is ${value * 0.9}");

}
else
{
    Console.WriteLine($"Your total is ${value}");
}