﻿Console.Clear();

//Обьявляем переменных
int inputNumber;
int inputPow;
int resultVariantMath;
int resultVariantFor;

void ReadNumbers()
{
    //Принимаем число
    Console.Write("Введите число: ");
    inputNumber = int.Parse(Console.ReadLine());

    //Принимаем степень
    Console.Write("Введите степень: ");
    inputPow = int.Parse(Console.ReadLine());
}

void VariantMath()
{
    resultVariantMath = (int)Math.Pow(inputNumber, inputPow);
}

void VariantFor()
{
    resultVariantFor = 1;
    for (int i = 0; i < inputPow; i++)
    {
        resultVariantFor *= inputNumber;
    }
}

void PrintResult()
{
    Console.WriteLine("-----Первый вариант-----");
    Console.WriteLine($"Число {inputNumber} в степени {inputPow} равно: {resultVariantMath}");

    Console.WriteLine("-----Второй вариант-----");
    Console.WriteLine($"Число {inputNumber} в степени {inputPow} равно: {resultVariantFor}");
}
//Вызываем метод считывания переменных
ReadNumbers();
//Вызываем первый вариант
VariantMath();
//Вызываем второй
VariantFor();
//Вызываем метод вывода
PrintResult();
