// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] GetArrResult(string[] arr)
{
    int newArrIndex = 0;
    string[] newArr = Array.Empty<string>();
    foreach (string item in arr)
        {
            if(item.Length <= 3){//длина строки
            Array.Resize(ref newArr, newArr.Length + 1);
            newArr[newArrIndex] = item;
            newArrIndex++;
            }
        }
    return newArr; 
}

void PromptArr(){
    Console.WriteLine("Введите желаемую длину массива");
    try
    {
        int arrLength = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        string[] arr = new string[arrLength];
        for (int i = 0; i < arrLength; i++)
        {
            Console.WriteLine($"Введите значение массива №{i + 1}");
            var tmp = Console.ReadLine();
            if(tmp == null){
                arr[i] = String.Empty;
            } else arr[i] = tmp;
            Console.Clear();
        }
        ShowArrResult(arr);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Processing failed: {e.Message}");
        Console.WriteLine("(Вы ввели в поле значения длины массива неверное значение!)");
        Console.WriteLine();
    }
}

void ShowArrResult(string[] arr){
    string[] newArr = GetArrResult(arr);
    Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам:");
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
        {
            Console.Write(arr[i]);
        }
        else Console.Write($", {arr[i]}");
    }
    Console.Write("] -> [");
    for (int i = 0; i < newArr.Length; i++)
    {
        if (i == 0)
        {
            Console.Write(newArr[i]);
        }
        else Console.Write($", {newArr[i]}");
    }
    Console.Write("]");
}

PromptArr();
