namespace Exercise2
{
    public abstract class Property
    {
        private static ulong _lastId = 0;
        
        public ulong Id { get; }
        public string Address { get; }
        public decimal BasePrice { get; }
        public int SquareMeters { get; }

        protected Property(string address, decimal basePrice, int squareMeters)
        {
            Id = ++_lastId;
            Address = address;
            BasePrice = basePrice;
            SquareMeters = squareMeters;
        }

        public abstract decimal CalculatePrice();
    }
}