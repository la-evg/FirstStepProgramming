System.Random numberSintezator = new Random();
void VariantNative()
{
    int i = 0;
    Console.Write("[");
    while (i < 8 - 1)
    {

        Console.Write(numberSintezator.Next(0,19) + ",");
        i++;
    }
    Console.Write(numberSintezator.Next(0,19));
    Console.Write("]");
}
VariantNative();
