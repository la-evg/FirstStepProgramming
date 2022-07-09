var week = new Dictionary<int, string>()
{
    { 1, "Понедельник"},
    { 2, "Вторник"},
    { 3, "Среда"},
    { 4, "Четверг"},
    { 5, "Пятница"},
    { 6, "Суббота"},
    { 7, "Воскресенье"}
};

string? inputNum = Console.ReadLine();
if(inputNum != null)
{
    Console.WriteLine(week[int.Parse(inputNum)]);
}