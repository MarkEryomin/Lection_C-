  
//   Вариант 1 ничего не принимают,ничего не отдают

void Method1()
{
    Console.WriteLine("Автор...");
}

// Method1();



//   Вариант 2 ничего не возвращают ,но могут принимать что-то

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i=0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4 );
// Method21(count: 4 , msg :"Новый текст");


//   Вариант 3 что-то возвращает,но ничего не принимает
int Method3()
{
    return DateTime.Now.Year;
}

int year =Method3();
// Console.WriteLine(year);


//   Вариант 4 что-то принимает и что-то отдаёт

// string Method4 (int count, string text)
// {
//     int i =0;
//     string result= string.Empty;

//     while (i<count)
//     {
//         result=result+text ;
//         i++;
//     }
//     return result ;

// }

string Method4 (int count, string text)
{

    string result= string.Empty;
    for (int i =0;i<count;i++)
    {
        result=result+text ;
    }
    return result ;

}
string res = Method4(10, "xyz");
Console.WriteLine(res);


// цикл в цикле
