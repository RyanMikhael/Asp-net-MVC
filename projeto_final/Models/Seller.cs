using System.Collections.Generic;
namespace projeto_final.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();


        public void addSales( SalesRecord sr ){}
        public void removeSales(SalesRecord sr){}

    }
}