//Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int [] list = new int [10]; // Задаем массив

void FillArray(int[] collection) //Заполнениие массива
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 100);
        index ++;
    }
}
FillArray(list);

void PrintArray(int[] num) //Вывод массива
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.WriteLine(num[i]+ " ");
    }
}

bool IsCheck(int num) //Создание метода для проверки условия
{
    return ((num > 20) && (num < 90));
}



int GetCount(int[] array) //Метод, который возвращает кол-во эллементов с простыми значениями
{
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
    {
       if(IsCheck(array[i]))
       {
        count++;
       } 
    }
    return count;
}    
PrintArray(list); 
Console.WriteLine();
Console.WriteLine(GetCount(list));