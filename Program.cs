// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void OutNumbers(int num)
{
    int i=1;
    while (i <= num)
    {
        Console.Write(Math.Pow(i,3)+ ",");
        i++;
    }
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

// Ввод данных от пользователя
int num = GetNum("Введите число: ");

// определить число 
OutNumbers(num);
// вывод
