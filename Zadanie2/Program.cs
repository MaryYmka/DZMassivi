//Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int [] list = new int [10]; //Задаем массив;

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


bool IsPrime(int num) //Создание метода для проверки условия
{
    return (num %2 ==0);
}

int GetCountPrimeNumber(int[] array) //Метод, который возвращает кол-во эллементов с простыми значениями
{
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
    {
       if(IsPrime(array[i]))
       {
        count++;
       } 
    }
    
return count;
}

PrintArray(list); 
Console.WriteLine();
Console.WriteLine(GetCountPrimeNumber(list));

