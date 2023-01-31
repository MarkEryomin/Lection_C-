// Собрать строку с числами от a до b ,a<=b

string NumbersFor(int a,int b)
{
    string result =String.Empty;
    for(int i =a;i<=b;i++)
    {
        result+=$"{i} ";
    }
    return result;
} 

string NumbersRec(int a,int b)
{
    if (a<=b) return $"{a} "+NumbersRec(a+1,b);
    else return String.Empty;
}

string NumbersRecRew(int a,int b)
{
    if (a<=b) return NumbersRecRew(a+1,b)+$"{a} ";
    else return String.Empty;
}

string NumbersForRew(int a,int b)
{
    string result =String.Empty;
    for(int i =b;i>=a;i--)
    {
        result+=$"{i} ";
    }
    return result;
}

Console.WriteLine(NumbersFor(1,10));
Console.WriteLine(NumbersRec(1,10));


Console.WriteLine(NumbersForRew(1,10));
Console.WriteLine(NumbersRecRew(1,10));