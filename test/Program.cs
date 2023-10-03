/*
Написать программу, которая из имеющегося массива строк формирует новый 
массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный 
массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно 
массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

*/
string[] arr1 = new string[5] {"Hello", "2", "world", "456","34"};
string[] arr2 = new string[arr1.Length];
void FinalArr(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length<=3)
        {
            array2[count]=array1[i];
            count++;
        }
        
    }
}
void PrintFinalArr(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
         Console.Write(array[i]);
       if (i<array.Length - 3)
       {
        Console.Write (", ");
       }
    }
    Console.WriteLine("]");
}
FinalArr(arr1,arr2);
PrintFinalArr(arr2);

        
