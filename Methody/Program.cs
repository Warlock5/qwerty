/* Метод1 
Выводит на монитор информацию

viod Method1()
{
    System.Console.WriteLine("Автор...");
}
Method1();
*/

//Метод2 Ничего не возвращает но может принимать аргументы

/*
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения"); 
*/

//Когда нужно указать какое то количество аргументов

/*
void Method21(string msg, int count)
{
    int i = 0; 
    while (i < count)
    {
      System.Console.WriteLine( msg);
      i++; 
    }
}
Method21("Текст", count: 4);
*/
// Method4 Что-то возвращают, но ничего не принимают- 
// например запрос даты, время.
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);
*/

// Method4 ВАЖНО! Метод что-то принимает и что-то возвращает.

/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "wasad  ");
System.Console.WriteLine(res);
*/
/*
string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i =0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "wasad  ");
System.Console.WriteLine(res);
*/

//Таблица умножения
/*
for (int i = 2; i < 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}");   
    }
    System.Console.WriteLine();
}
*/

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгороде,"
            + "вы бы взяли приступом согласие прусского короля."
            +" Вы так краснооречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replase(text, ' ', '-' );

System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replase(newText, 'к', 'К' );
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replase(newText, 'С', 'с' );
System.Console.WriteLine(newText);




