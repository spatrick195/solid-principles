namespace SOLID._03.LiskovSubstitution;

public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("I can fly!");
    }
}

/*
 * This class violates LSP because it alters the behaviour of Bird.
 */
public class Penguin : Bird
{
    public override void Fly()
    {
        throw new Exception("I can't fly!");
    }
}
