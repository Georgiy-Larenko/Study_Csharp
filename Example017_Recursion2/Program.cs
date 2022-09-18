// Формула для расчета факториала


// double Factorial(int n)
// {
//     if (n == 1) return 1;       // 1! = 1     0! = 1
//     else return n * Factorial(n - 1);

// }

// for (int i = 1; i < 21; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }



// Формула для расчета чисел Феббоначи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int num)
{
    if (num == 1 || num == 2) return 1;       // Если значение num = 1 или (||) num = 2
    else return Fibonacci(num - 1) + Fibonacci(num - 2);
}

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($" Fibbo {i} = {Fibonacci(i)}");
}