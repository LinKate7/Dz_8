﻿// Interface Segregation Principle цей solid порушено
Console.WriteLine("");
interface IPrice
{
    void ApplyDiscount(string discount);
    void ApplyPromocode(string promocode);
    void SetPrice(double price);
}


interface IAspect
{
    void SetColor(byte color);
    void SetSize(byte size);
}

class Book : IPrice
{
    private double price;
    public void ApplyDiscount(string discount)
    {
        Console.WriteLine("The book has discount " + discount);
    }
    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine("The book has promocode " + promocode);
    }
}

class Clothes : IAspect, IPrice
{
    private double price;
    private byte color;
    private byte size;

    public void SetSize(byte size)
    {
        this.size = size;
    }
    public void SetColor(byte color)
    {
        this.color = color;
    }
    public void ApplyDiscount(string discount)
    {
        Console.WriteLine("The clothes has discount " + discount);
    }
    public void SetPrice(double price)
    {
        this.price = price;
    }

    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine("The clothes has promocode " + promocode);
    }

}

