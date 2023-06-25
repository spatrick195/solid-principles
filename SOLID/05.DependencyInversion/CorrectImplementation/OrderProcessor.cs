namespace SOLID._05.DependencyInversion.CorrectImplementation;

// Here, we are relying on abstractions, and not the concrete implementations
public interface IOrder
{
}

public class Order : IOrder
{
}

public interface IOrderDataAccess
{
    void Save(IOrder order);
}

public class OrderDataAccess : IOrderDataAccess
{
    public void Save(IOrder order)
    {
    }
}

public class OrderProcessor
{
    private readonly IOrderDataAccess _dataAccess;

    public OrderProcessor(IOrderDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public void Process(IOrder order)
    {
        _dataAccess.Save(order);
    }
}
