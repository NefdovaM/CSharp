Console.Write("Введите число: ");
string n = Console.ReadLine();
int userNumber = int.Parse(n);
bool isEven = userNumber%2 == 0;

if (isEven)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}

