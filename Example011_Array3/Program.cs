void FillArray(int[] collection)  // Функция заполнения массива случайными переменными. Void - метод без возвращения в стартовую позицию. Не нужно дописывать return; в конце цикла.  
{
    int length = collection.Length; // Получение длинны массива 
    int index = 0; // Стартовая позиция в массиве 
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // Положить в переменную Collection рандомное (New Random) целое (Next) число в диапазоне от 1 до 10 (1,10)
        index++; // index = index + 1;
    }
}

void PrintArray(int[] col) // Функция печати созданного массива.
{
    int count = col.Length;
    int position = 0;
    while (position < count) // Пока номер позиции меньше чем последняя позиция в массиве
    {
        Console.WriteLine(col[position]); // Печатаем (Console.WriteLine) значение текущего элемента в массиве (col[position])
        position++; // position = position + 1; 
    }
}

int IndexOf(int[] collection, int find) // Метод с возвратом позиции. 
{
    int count = collection.Length; // Получение данных длинны массива collection (переменная count)
    int index = 0; // Стартовая позиция (index) в массиве
    int position = -1; // Введение отдельного банка для хранения позиции. По - Умолчанию -1 (Если элемента нет то будет -1). 

    while (index < count)
    {
        if (collection[index] == find) // Eсли значение(index) в массиве(collection)
        {
            position = index;
        } 
        index++; //index = index + 1;
         // Вернуть значение элемента (position) к первоначальному значению (0)
    }
    return position;
}

int[] array = new int[10]; // Создание массива в котором 10 элементов 

FillArray(array);
PrintArray(array);
Console.WriteLine(); // Выводим пустую строку для освобождения после вывода массива. 


int pos = IndexOf(array, 444); // В pos закладываем результаты функции IndexOf над массивом (array) и указываем что ищем (4)
Console.WriteLine(pos); // Печать переменной pos

