// Задайте произвольную строку. Выясните,
// является ли она палиндромом.


string PalindromStr (string msg)

{
    bool a = false;
    string b = "Нет";
    for (int i = 0; i < msg.Length/2; i++)
    {
        if (msg[i] == msg[msg.Length - i - 1])
        {
            a = true;
        } else 
        {
            a = false;
        }
    }
    if (a == true)
    {
        b = "Да";
    } else
    {
         b = "Нет";
    }
    return b;
}

string str = "556655";
Console.Write(PalindromStr(str));