// Дан массив 6 8 3 2 1 4 5 7 нужно упорядочить


int[] arr = { 1, 6, 7, 8, 2, 3, 5, 9, 4, 1, 1 }; // Задаем массив 

void PrintArray(int[] array)                        // Функция выдачи массива
{
    int count = array.Length;                       // Задаем переменную count которая будет равна длине массива

    for (int i = 0; i < count; i++)                 // условие пока переменная i меньше или равна count (длинне массива), увеличиваем на i+1
    {
        Console.Write($"{array[i]} ");              // При этом печатаем значение i - элемент массива
    }
    Console.WriteLine();                            // после того как напечатали делаем отступ
}

PrintArray(arr);                                    // вызываем функцию
Console.WriteLine();                                // делаем отступ




void SelectionSort(int[] array)                     // Создаем функцию сортировки массива (минимальное значение массива переносим в начало)
{
    for (int i = 0; i < array.Length - 1; i++)      // Пока значение i не будет равно длинне массива - 1 элемент увеличиваем на i + 1
    {
        int minPosition = i;                        // при этом создаем минимальную позицию и присваеваем значение элемента i

        for (int j = i + 1; j < array.Length; j++)              // пока j не будет равна длинне массива 
        {
            if (array[j] < array[minPosition]) minPosition = j;    // условие Если значение j будет меньше значения переменной i то j будет равно minPosition
        }

        int temp = array[i];                        // создаем временную переменную и ей по умолчанию равно значение переменной i 
        array[i] = array[minPosition];              // переменная i равна переменной minPosition
        array[minPosition] = temp;                  // minPosition закладываем как временную (подмена)
    }
}

SelectionSort(arr);
PrintArray(arr);