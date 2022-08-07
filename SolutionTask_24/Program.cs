Console.Clear();
Console.Write("Введите число: ");

int inputNumber = int.Parse(Console.ReadLine());

void VariantSimple()
{
    int sumOfNumbers = 0;
    for (int i = 1; i <= inputNumber; i++)
    {
        sumOfNumbers += i;
    }
    Console.WriteLine("Сумма чисел от 1 до " + inputNumber + " = " + sumOfNumbers);
}

void VariantGauss()
{
    long sumOfNumbers = 0;
    int i = 1;
    sumOfNumbers = ((i + inputNumber) * inputNumber) / 2;
    Console.WriteLine("Сумма чисел от 1 до " + inputNumber + " = " + sumOfNumbers);

}
int t = Environment.TickCount;
VariantSimple();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
VariantGauss();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);
