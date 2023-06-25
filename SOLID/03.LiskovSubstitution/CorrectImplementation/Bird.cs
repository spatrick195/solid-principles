namespace SOLID._03.LiskovSubstitution.CorrectImplementation;

/*
 * Now, we do not modify the original behaviour of Bird.
 * Implementing the Fly() method in the Penguin class, even though penguins cannot fly, is not an ideal solution. To address this, we should use an IFlyable interface and implement it only for classes where flying is relevant.
 */

public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Sparrows can fly.");
    }
}

public class Penguin : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Penguins can't fly.");
    }
}

