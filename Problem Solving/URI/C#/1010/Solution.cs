using System;

class Solution
{
    private const char SPLIT_SEPARATOR = ' ';
    private const int INDEX_UNITS = 1;
    private const int INDEX_PRICE_PER_UNIT = 2;

    static void Main(string[] args)
    {
        var productOneLine = Console.ReadLine();
        var productTwoLine = Console.ReadLine();
        
        CalculatePayment(productOneLine, productTwoLine);
    }

    private static void CalculatePayment(string productOneLine, string productTwoLine)
    {
        string[] productOne = productOneLine.Split(SPLIT_SEPARATOR);
        string[] productTwo = productTwoLine.Split(SPLIT_SEPARATOR);
        
        double paymentForProductOne = GetPaymentForProduct(productOne);
        double paymentForProductTwo = GetPaymentForProduct(productTwo);

        double payment = paymentForProductOne + paymentForProductTwo;
        Console.WriteLine($"VALOR A PAGAR: R$ {payment.ToString("0.00")}");
    }

    private static double GetPaymentForProduct(string[] product)
    {
        int productOneUnits = int.Parse(product[INDEX_UNITS]);
        double productOnePricePerUnit = double.Parse(product[INDEX_PRICE_PER_UNIT]);
       
       return productOneUnits * productOnePricePerUnit;
    }
}
