namespace Exercise2
{
    public class House : Property
    {
        private readonly PricingRules _rules;

        public bool HasGarden { get; }

        public House(PricingRules rules, string address, decimal basePrice, int squareMeters, bool hasGarden) : base(address, basePrice, squareMeters)
        {
            _rules = rules;
            HasGarden = hasGarden;
        }

        public override decimal CalculatePrice()
        {
            decimal price = BasePrice + (SquareMeters * _rules.HousePricePerSquareMeter);
            if (HasGarden) price += _rules.HouseGardenPremium;
            return price;
        }
    }
}
