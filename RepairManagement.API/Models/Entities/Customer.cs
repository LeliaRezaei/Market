namespace RepairManagement.API.Models.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public int BillingId { get; set; }
        public Billing Billing { get; set; }

    }
}
