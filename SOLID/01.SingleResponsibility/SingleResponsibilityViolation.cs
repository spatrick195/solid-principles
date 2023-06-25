namespace SOLID._01.SingleResponsibility;
/*
    SaveProduct(): The SaveProduct() method implies that the class is responsible for handling the persistence or storage of product data. If there are any changes or updates related to how products are saved or stored, such as using a different database system or implementing additional validation checks during saving, this method would need to be modified.
    
    CalculateVat(decimal price): The CalculateVat() method suggests that the class is responsible for calculating the VAT (Value Added Tax) for a given price. Any changes to VAT calculation rules, such as modifying tax rates or introducing new tax regulations, would require modifying this method.
    
    Therefore, this class has two reasons to change and thus violates the single responsibility principle.
    
    To fix this, I will move the CalculateVat implementation into it's own class.
    See the following directory for the correct implementation: ./01.SingleResponsibility/CorrectImplementation
    
 */
public class Product
{
    public void SaveProduct()
    {
    }
    
    public decimal CalculateVat(decimal price)
    {
        return 0m;
    }
}