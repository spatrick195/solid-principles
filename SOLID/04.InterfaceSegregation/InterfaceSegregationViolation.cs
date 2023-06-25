namespace SOLID._04.InterfaceSegregation;

/*
 * This violates the Interface Segregation Principle because SimplePrinter is forced to use methods that it does not to implement.
 */
public interface IAllInOnePrinter
{
    void Print();
    void Scan();
    void Fax();
}

public class SimplePrinter : IAllInOnePrinter
{
    public void Print()
    {
    }

    public void Scan()
    {
        throw new NotImplementedException();
    }

    public void Fax()
    {
        throw new NotImplementedException();
    }
}
