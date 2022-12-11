namespace Animal;

public class Mouse : Animal
{
    public Mouse(int age, string color, string place) : base(age, color, place)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Бегаю");
    }

    public override void Eat()
    {
        Console.WriteLine("Ем пшеницу");
    }
}
