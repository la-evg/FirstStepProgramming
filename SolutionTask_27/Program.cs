Console.Clear();
Console.Write("Введите число: ");
int inputNumber = int.Parse(Console.ReadLine());
int sum = 0;

int CalculateSum()
{
    while(inputNumber > 10){
        sum = sum + inputNumber % 10;
        inputNumber /= 10;
    }
    sum += inputNumber;
    return sum;
}
Console.WriteLine($"Сумма чисел в {inputNumber} равна {CalculateSum()}");
