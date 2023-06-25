namespace SOLID._04.InterfaceSegregation.CorrectImplementation;


/*
 * Here, we have segregated each feature of the printer into separate interface.
 * Now, SimplePrinter does not need to implement Scan or Fax, and IAllInOnePrinter can simply inherit the features required.
 */
public interface IPrint
{
    void Print();
}

public interface IScan
{
    void Scan();
}

public interface IFax
{
    void Fax();
}

public interface IAllInOnePrinter : IPrint, IScan, IFax
{
    
}

public class SimplePrinter : IPrint
{
    public void Print()
    {
    }
}