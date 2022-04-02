// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
// меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
// обойтись исключительно массивами.

Console.Clear();

string[] arry = { "abcd", "xyz", "tttt", "$$$", "1234", "@@@", "333", "1234", "111", "abcd", "137", "77", "187" };
int count = 0;
int length = 0;

foreach (string elmnt in arry)
{
    if (elmnt.Length <= 3)
    length++;
}

string[] newArry = new string[length];

for (int j = 0; j < arry.Length; j++)
{
    if (arry[j].Length <= 3)
    {
        newArry[count] = arry[j];
        count++;
        Console.Write($"\t{count - 1} ");
    }
}

Console.WriteLine();
foreach (string elmnt in newArry)
{
    Console.Write($"\t{elmnt} ");
}

Console.ReadLine();