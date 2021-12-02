namespace projeto_final.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }
    }
}