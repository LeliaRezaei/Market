namespace RepairManagement.API.Models.Entities
{
    public class CustomerBilling: BaseEntity

    {
        public string TypeOfService { get; set; }
        public string PaymentMethod { get; set; }
    }
}
