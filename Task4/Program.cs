// Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string[] ChangeWordsArray (string[] array)
{   string temp = "";
    for(int i = 0; i < array.Length/2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;

    }
    return array;
}

string phrase = "1 2 3";
string[] words = phrase.Split(' ');
string[] words2 = ChangeWordsArray(words);
PrintArray(words2);
