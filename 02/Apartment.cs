namespace Exercise2
{
    public class Apartment : Property
    {
        private readonly PricingRules _rules;

        public int Floor { get; }

        public Apartment(PricingRules rules, string address, decimal basePrice, int squareMeters, int floor) : base(address, basePrice, squareMeters)
        {
            _rules = rules;
            Floor = floor;
        }

        public override decimal CalculatePrice()
        {
            decimal price = BasePrice + (SquareMeters * _rules.ApartmentPricePerSquareMeter);
            if (Floor > _rules.HighFloorThreshold) price += _rules.ApartmentHighFloorPremium;
            return price;
        }
    }
}