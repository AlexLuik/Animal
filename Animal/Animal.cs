namespace Animal;
public abstract class Animal
{
    protected string Color { get; set; }
    protected int Age { get; set; }
    protected string Place { get; set; }

    protected Animal(int age, string color, string place)
    {
        Age = age;
        Color = color;
        Place = place;
    }

    public abstract void Move();

    public abstract void Eat();
}