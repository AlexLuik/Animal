namespace Animal;

public class Owl : Animal
{
    public Owl(int age, string color, string place) : base(age, color, place)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Летаю");
    }

    public override void Eat()
    {
        Console.WriteLine("Ем мышей");
    }
}
