int[] array = {11,21,23,4,15,4,17,81};

int n = array.Length;
int find= 4;

int index =0;

while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

