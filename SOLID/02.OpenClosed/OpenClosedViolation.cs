namespace SOLID._02.OpenClosed;

/*
 * This class violates the Open-Closed Principle because it requires modifications to the MakeSound method & AnimalType enum to make another sound, for example, if I wanted to implement a sound for a cow I would need to change add a Cow field to the Enum, and another case to handle that.
 */
public enum AnimalType { Dog, Cat }

public class AnimalSound
{
    public void MakeSound(AnimalType animal)
    {
        switch (animal)
        {
            case AnimalType.Dog:
                Console.WriteLine("Woof");
                break;
            case AnimalType.Cat:
                Console.WriteLine("Meow");
                break;
        }
    }
}