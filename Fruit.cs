using System;

public abstract class Fruit
{
    public decimal Price { get; set; }
    public string Sort { get; set; }

    public abstract void Taste();
}

public class Apple : Fruit
{
    public int VitaminA { get; set; }
    public int VitaminB { get; set; }

    public override void Taste()
    {
        Console.WriteLine("Sweet.");
    }
}

public class Pineapple : Fruit
{
    public int VitaminE { get; set; }
    public int VitaminD { get; set; }

    public override void Taste()
    {
        Console.WriteLine("Delicious");
    }
}

public class Orange : Fruit
{
    public int VitaminC { get; set; }

    public override void Taste()
    {
        Console.WriteLine("Sour");
    }
}
