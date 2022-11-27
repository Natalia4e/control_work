// Задача. Написать программу,которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры,либо задать на старте выполнения алгоритма.

string Prompt(string message)
{
    Console.Write(message);
    string data = Console.ReadLine();
    return data;
}

string message = Prompt ("Введите данные через, ");
string[] arr = message.Split(",");
string[] arr2 = new string[arr.Length];
int j = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if ( arr[i].Length <= 3 )
        {
            arr2[j] = arr[i];
            j++;
        }      
    }

Console.WriteLine(String.Join(" ",arr2));


