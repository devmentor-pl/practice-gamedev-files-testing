namespace Exercise2
{
    public class PricingRules
    {
        public decimal LandPricePerSquareMeter { get; set; } = 100m;
        public decimal HousePricePerSquareMeter { get; set; } = 1000m;
        public decimal HouseGardenPremium { get; set; } = 15000m;
        public decimal ApartmentPricePerSquareMeter { get; set; } = 800m;
        public decimal ApartmentHighFloorPremium { get; set; } = 5000m;
        public int HighFloorThreshold { get; set; } = 5;
    }
}
