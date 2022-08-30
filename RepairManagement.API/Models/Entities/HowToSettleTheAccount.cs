namespace RepairManagement.API.Models.Entities
{
    public class HowToSettleTheAccount :BaseEntity
    {
        public string? BankCard  { get; set; }

        public string?  Cash { get; set; }
    }
}
