// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше, либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] 
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”] 
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите количество элементов массива: ");
int size  =  Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[size];

for (int i = 0; i < size; i++){
	Console.Write("Введите элемент массива: ");
    string result = Console.ReadLine();
	array1[i] = result;  
}
Console.WriteLine();
Console.Write("Введенный массив: [");
Console.Write(string.Join(",", array1));
Console.Write("]");


int count = 0;
int maxSymbols = 3;

for (int i = 0; i < array1.Length; i++)
{
	if(array1[i].Length <= maxSymbols) count++;
}
Console.WriteLine();
Console.Write("Полученный массив: [");


string[] array2 = new string[count];
int j = 0;
for (int i = 0; i < array1.Length; i++)
{
    if(array1[i].Length <= maxSymbols)
    {
        array2[j] = array1[i];
        Console.Write(array2[j] + ",");
        j++;
    }
}
Console.Write("]");