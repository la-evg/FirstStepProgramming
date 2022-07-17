// Является ли этот день выходным
Console.Clear();
void weekend()
{
    Console.Write("Введите число дня недели: ");
    string? dayLine = Console.ReadLine();
    if (dayLine != null)
    {
        int dayNumber = int.Parse(dayLine);
        if (dayNumber < 1 ^ dayNumber > 8)
        {
            Console.WriteLine("Число от от 1 до 7");
            weekend();
        }
        else
        {
            if (dayNumber == 6 ^ dayNumber == 7)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
        }
    }
}

weekend();
