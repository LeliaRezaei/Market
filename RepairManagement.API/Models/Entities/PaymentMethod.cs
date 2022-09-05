namespace RepairManagement.API.Models.Entities
{
    public class PaymentMethod : BaseEntity
    {
        public int? BankCard { get; set; }

        public int? Cash { get; set; }
    }
}
