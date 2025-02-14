namespace SM.Lib.Helpers;

public static class PriceCalculator
{
    public static double MarginPrice(double price, double marginValue)
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

    public static void CalculateVatPriceVoid(double price, double vat)
    {
        var value = price * (vat / 100);
    }

    public static bool VatIsNotNull(double price, double vat)
    {
        return (price * (vat / 100)) != 0;
    }
}