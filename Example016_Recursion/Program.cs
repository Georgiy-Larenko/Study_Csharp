// Примеры рекурсии и двумерных массивов

string[,] table = new string[2, 5];  // Задаем строчный двумерный массив (string) где 2 - количество строк, а 5 - столбцов (отсчет от 0)

// По умочанию строка пустая String.Empty

// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]

// table[1, 2] = "слово"; // задаем значение переменный в 1 строке 2 столбце.  

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.Write($"- {table[rows, columns]} -");
//     }
// }




void PrintArray(int[,] matr)    // Создаем функцию создания двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)   //matrix.GetLength - задается длина строки или столбца. где 0 - это параметр строки (3), а 1 - строки (4)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();    // После того как заполнили все столбики строки переходим на новую строку
    }
}

void FillArray(int[,] matr)    // Создаем функцию по заполнению двумерного массива случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}


int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);