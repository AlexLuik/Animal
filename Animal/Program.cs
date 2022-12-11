using Animal;

var owl = new Owl(2, "gray", "tree");
var fox = new Fox(2, "orange", "forest");
var mouse = new Mouse(3, "brown", "field");

Console.WriteLine("Сова:");
owl.Move();
owl.Eat();

Console.WriteLine();
Console.WriteLine("Лиса:");
fox.Move();
fox.Eat();

Console.WriteLine();
Console.WriteLine("Мышь:");
mouse.Move();
mouse.Eat();