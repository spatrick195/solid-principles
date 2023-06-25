namespace SOLID._05.DependencyInversion;

/*
 * This violates Dependency Inversion Principle because we are not relying on any abstractions
 * and instead are relying on concrete implementations
 */
public class Order
{
    
}

public class OrderDataAccess
{
    public void Save(Order order){}   
}

public class OrderProcessor
{
    private OrderDataAccess _dataAccess;

    public OrderProcessor()
    {
        _dataAccess = new OrderDataAccess();
    }

    public void Process(Order order)
    {
        _dataAccess.Save(order);
    }
}
