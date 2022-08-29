namespace RepairManagement.API.Models.Entities
{
    public class Customer : BaseEntity// Moshtary
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }
        public int  Billing { get; set; }

    }
  
}
