namespace RepairManagement.API.Models.Entities
{
    public class Billing : BaseEntity

    {
        public int TypeOfServiceId { get; set; }
        public TypeOfService TypeOfService { get; set; }
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
