# Методы
## Вид 1 (Ничего не принимают и ничего не возвращают)

void Method1()
{
    Console.WriteLine("...");
}
Method1(); <-- Способ вызова. Скобки обязательны.

## Вид 2 (Что-то принимают, но ничего не возвращают)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method2.1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2.1(msg: "Текст", 4);
Method2.1(count: 4, msg:"Текст");

## Вид 3 (Что-то возвращают, но ничего не принимают)

int Method3 ()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

## Вид4 (Что-то принимают и что-то возвращают)
int Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i > count)
    {
        result = result + text;
        i++
    }
    return result;
}
string res = Method4(10, "WTF");
Console.WriteLine(res);

