using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public decimal CalculateTotalPrice()
    {
        decimal productTotal = 0;

        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCost();
        }
        decimal shippingCost;
        
        if (_customer.IsInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return productTotal + shippingCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel += product.GetPackingLabel() + "\n";            
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
}