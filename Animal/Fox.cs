namespace Animal;

public class Fox : Animal
{
    public Fox(int age, string color, string place) : base(age, color, place)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Бегаю");
    }

    public override void Eat()
    {
        Console.WriteLine("Ем зайцев");
    }
}
