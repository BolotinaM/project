// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Задайте значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

Summ(m, n);

void Summ(int m, int n)
{
    Console.Write(SummMN(m - 1, n));
}

// Функции задачи № 2
    // Функция  получения суммы чисел от M до N
    int SummMN(int m, int n)
    {
        int result = m;
        if (m == n)
            return 0;
        else
        {
            m++;
            result = m + SummMN(m, n);
            return result;
        }
}