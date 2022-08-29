namespace RepairManagement.API.Models.Entities
{
    public class CustomerBilling: BaseEntity

    {
        public int TypeOfService { get; set; }
        public int PaymentMethod { get; set; }
    }
}
