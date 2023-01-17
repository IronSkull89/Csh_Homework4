using System.Threading.Tasks;

int task;
int SelectionTask()
{
    Console.Write("Выберите задачу (от 1 до 3): ");
    if (!int.TryParse(Console.ReadLine(), out int task) || task > 3 || task < 1) task = SelectionTask();
    return task;
}

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int SetNumber()
{
    Console.Write("Введите число: ");
    if (!int.TryParse(Console.ReadLine(), out int number)) number = SetNumber();
    return number;
}

int SetNaturalDegree()
{
    Console.Write("Введите натуральную степень числа: ");
    if (!int.TryParse(Console.ReadLine(), out int number) || (number < 1)) number = SetNumber();
    return number;
}

int Exponentiation (int number, int degree)
{
    int exp = number;
    for (int i = 1; i < degree; i++)
    { 
        exp *= number; 
    }
    return exp;
}



//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SetPositivNumber()
{
    Console.Write("Введите число: ");
    if (!int.TryParse(Console.ReadLine(), out int number) || number < 0) number = SetNumber();
    return number;
}

int SumDigits(int number)
{
    int sumDigits = 0;
    
    while (number > 0)
    {
        sumDigits += number % 10;
        number /= 10;
    }
    return sumDigits;
}


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)
int[] SetArray (int count)
{
    int[] Array = new int[count];
    var rand = new Random();
    for (int i = 0; i < count; i++)
    {
        Array[i] = rand.Next();
    }
    return Array;
}

//--------------------------------------------

task = SelectionTask();
if (task == 1)
{
    int number = SetNumber();
    int degree = SetNaturalDegree();
    Console.WriteLine($"{number} в степени {degree} равна {Exponentiation(number, degree)}");
}
else if (task == 2)
{
    int number2 = SetPositivNumber();
    Console.WriteLine($"Сумма цифр в числе {number2} равна {SumDigits(number2)}");
}
else if (task == 3)
{
    int[] Array = SetArray(8);
    Console.WriteLine(String.Join(" ",Array));
}