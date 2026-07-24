using System;

public class Product
{
    // Attributes (Private)
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    // Methods
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _id;
    }
    
    // Getters needed for the Packing Label
    public double GetPrice() { return _price; }
    public int GetQuantity() { return _quantity; }
}