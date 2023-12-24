// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.


string Concat(char[,] array)
{
    string str = "";

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            str = str + array[i,j];
        }
        

    }
    return str;
}

char[,] letters = { {'a', 'b', 'c'}, {'d', 'e', 'f'} };
string result = Concat(letters);

Console.WriteLine(result);