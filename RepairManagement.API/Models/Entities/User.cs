namespace RepairManagement.API.Models.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public int Password { get; set; }
    }
}
