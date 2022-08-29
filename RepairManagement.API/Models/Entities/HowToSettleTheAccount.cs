namespace RepairManagement.API.Models.Entities
{
    public class HowToSettleTheAccount :BaseEntity
    {
        public int? BankCard  { get; set; }

        public int?  Cash { get; set; }
    }
}
