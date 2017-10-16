namespace ForeignExchanged2.Models
{

    public class Rates
    {
        public int RateId { get; set; }
        public string Code { get; set; }
        public double TaxRate { get; set; }
        public string Name { get; set; }
    }
}
