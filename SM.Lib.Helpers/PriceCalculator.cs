namespace SM.Lib.Helpers;

public static class PriceCalculator
{
    private static double MarginPrice(double price, double marginValue)
    {
        return price * (marginValue / 100);
    }

    public static double CalculateClientPrice(double price, double marginValue, double vat)
    {
        return price + MarginPrice(price, marginValue) + vat;
    }

    public static double CalculateVatPrice(double price, double vat)
    {
        return price * (vat / 100);
    }
}