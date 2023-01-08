// Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "2, 4"
// N = 8 -> "2, 4, 6, 8"

Console.Write("Задайте значение N: ");
int N = Convert.ToInt32(Console.ReadLine());


void Result(int a)
{
 if (a == 0) return;
    if (a > 0)
    { 
        if (a % 2 == 0)
        {
            Console.WriteLine ($"{a}");
            Result(a-2);
        }
        else
        {
            a = a-1;
            Console.WriteLine ($"{a}");
            Result(a-2);  
        }
        
    }

}

Result(N);