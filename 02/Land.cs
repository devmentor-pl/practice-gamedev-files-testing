namespace Exercise2;

public class Land : Property
{
    private readonly PricingRules _rules;
    
    public Land(PricingRules rules, string address, decimal basePrice, int squareMeters) : base(address, basePrice, squareMeters)
    {
    }
    
    public override decimal CalculatePrice()
    {
        return BasePrice + (SquareMeters * _rules.LandPricePerSquareMeter);
    }
}