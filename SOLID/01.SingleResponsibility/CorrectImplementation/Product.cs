namespace SOLID._01.SingleResponsibility.CorrectImplementation;

/*
 * The responsibilities are now separated, and each class only has one reason to change.
 */
public class Product
{
    public void SaveProduct()
    {
    }
}

public class VatCalculator
{
    public decimal CalculateVat(decimal price)
    {
        return 0m;
    }
}