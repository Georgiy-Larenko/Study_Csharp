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

int[] array = new int[10]; // Создание массива в котором 10 элементов 

FillArray(array);
PrintArray(array);


