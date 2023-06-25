namespace SOLID._02.OpenClosed.CorrectImplementation;

/*
 * We don't need to modify the original code of an animal to make a sound. We can simply create a new class which inherits from IAnimal and implement it there.
 * This could also be done by making IAnimal an abstract class and then overriding the MakeSound() method in the sub-classes. 
 */
public interface IAnimal
{
    public void MakeSound();
}

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof");
    }
}