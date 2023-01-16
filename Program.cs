// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int SetNumber()
{
    Console.Write("Введите число: ");
    if (!int.TryParse(Console.ReadLine(), out int number))
    {
        number = SetNumber();
    }
    return number;
}

int SetNaturalDegree()
{
    Console.Write("Введите натуральную степень числа: ");
    if (!int.TryParse(Console.ReadLine(), out int number) || (number < 1))
    {
        number = SetNumber();
    }
    return number;
}


int number = SetNumber();
int degree = SetNaturalDegree();

int Exponentiation (int number, int degree)
{
    int exp = number; 
    for (int i = 1; i < degree; i++) exp *= number;
    return exp;
}

Console.WriteLine($"{number} в степени {degree} равна {Exponentiation(number, degree)}");