﻿// Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёртачками,
// маленькие буквы "к", заменить на большие "К", большие "С",на маленькие "с".

string text= "-Я думаю,- сказал князь, улыбаясь,- что ,"
            +"ежели бы вас послали вместо нашего милого Винценгероде,"
            +"вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадите мне чаю?- С Сахаром?";

// string s= "qwerty"
//            012345
// s[3] это r

string Replace(string text,char oldValue,char newValue)
{
    string result = string.Empty;

    int length= text.Length;
    for ( int i =0; i<length; i++)
    {
        if (text[i] == oldValue) result=result + $"{newValue}";
        else result=result + $"{text[i]}";
        
    }

    return result;
}
string newText=Replace(text,' ','|');
Console.WriteLine(newText);
Console.WriteLine();
string newText1=Replace(newText,'к','К');
Console.WriteLine(newText1);
Console.WriteLine();
string newText2=Replace(newText1,'С','с');
Console.WriteLine(newText2);