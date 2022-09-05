namespace RepairManagement.API.Models.Entities
{
    public class Billing : BaseEntity

    {
        public int TypeOfServiceId { get; set; }
        public string TypeOfService { get; set; }
        public int PaymentMethodId { get; set; }
        public string PaymentMethod { get; set; }
    }
}
