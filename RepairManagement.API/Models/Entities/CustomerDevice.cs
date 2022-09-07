namespace RepairManagement.API.Models.Entities
{
    public class CustomerDevice : BaseEntity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ProductCode { get; set; }

    }
}
