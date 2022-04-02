// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
// меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
// обойтись исключительно массивами.

Console.Clear();

char[] separators = new char[] { ' ', ';', '.', ',', '-', '<', '>',
                                '"', ':', '!', '?', '=', '(', ')' };
string[] selectedStringArry;                                
int length = 0;
int count = 0;

Console.Write("Enter a text that will be converted to string array: ");
string? text = Console.ReadLine();
string[] convertedStringArry = text!.Split(separators, StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < convertedStringArry.Length; i++)
{
    if (convertedStringArry[i].Length <= 3)
    {
        length++;
    }
}

selectedStringArry = new string[length];
Console.WriteLine();

for (int j = 0; j < convertedStringArry.Length; j++)
{
    if (convertedStringArry[j].Length <= 3)
    {
        selectedStringArry[count] = convertedStringArry[j];
        Console.WriteLine("{0, 3}   | {1, 5}", count, selectedStringArry[count].ToLower());
        count++;
    }
}