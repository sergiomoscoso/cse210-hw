using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    // Attributes (Private)
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    // Methods
    public double CalculateTotal()
    {
        double sum = 0;
        foreach (Product product in _products)
        {
            sum += product.GetTotalCost();
        }

        // Add shipping cost based on customer location
        double shipping = _customer.IsInUSA() ? 5.0 : 35.0;
        return sum + shipping;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        label.AppendLine("PACKING LABEL:");
        foreach (Product product in _products)
        {
            label.AppendLine($"Item: {product.GetName()} (ID: {product.GetId()})");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\nTo: {_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}