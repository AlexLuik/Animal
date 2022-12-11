using Exceptions;

try
{
    while (true)
    {
        Console.WriteLine("1. Ошибка сервера");
        Console.WriteLine("2. Деление на ноль");
        Console.WriteLine("3. Граница массива");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 0:
                throw new MException("Not found", 404);
            case 1:
                int zero = 0;
                int result = 1 / zero;
                break;
            case 2:
                var array = Array.Empty<string>();
                var element = array[1];
                break;
        }
    }
}
catch (MException e)
{
    Console.WriteLine($"{e.Message} {e.ErrorCode}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("Деление на ноль");
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine("Выход за границы массива");
}
