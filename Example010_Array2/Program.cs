int[] array = { 13, 22, 34, 45, 35, 76, 227, 98, 139 };

int n = array.Length; // Обозначение длинны массива
int find = 22;

int index = 0;

while (index < n)
{
    if (array[index] == find) // == это совпадение(равенство)
    {
        Console.WriteLine(index);
        break; // Прерывание цикла если условие выполняется (если несколько похожих значений)
    }
    index++; // index = index + 1;
}