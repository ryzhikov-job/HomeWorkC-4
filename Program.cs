// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
void RaseToaPower()
{
int a, b;
    while (true)
    {
    Console.WriteLine("Enter first number");
    string? firstNumber = Console.ReadLine();
    Console.WriteLine("Enter second number");
    string? secondNumber = Console.ReadLine();
    
        if (int.TryParse(firstNumber, out a) && int.TryParse(secondNumber, out b))
        {
            int result = (int)Math.Pow(a, b);
            Console.WriteLine($"Number {a} to the power {b} -> {result}");
            break;
        }
        else Console.WriteLine($"You entered non-numbers, check your input -> {firstNumber} and {secondNumber}, re-enter!");
    }
}

RaseToaPower();
*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
void SumOfDigits()
{
    while(true)
    {
    Console.WriteLine("Enter the number: ");
    string? entNumber = Console.ReadLine();
    if (int.TryParse(entNumber, out int number))
    {
        int sumDig = Calculation(number);
        Console.WriteLine($"The sum of the digits of the number {number} is equal to {sumDig}");
        break;
    }
    else Console.WriteLine($"You did not enter a number, check -> {entNumber} and enter the number again");
    }
}

int Calculation(int num)
{
    int sum = 0;
    num = Math.Abs(num);
    while (num > 0)
    {
        int digit = num % 10;
        sum += digit;
        num /= 10;
    }
    return sum;
}

SumOfDigits();
*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
int[] result = GetBinaryArray(8);
Console.WriteLine($"[{String.Join("; ", result)}]");

int[] GetBinaryArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
*/