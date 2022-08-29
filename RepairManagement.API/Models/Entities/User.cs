namespace RepairManagement.API.Models.Entities
{
    public class User : BaseEntity
    {
        public int UserName { get; set; }
        public int Password { get; set; }
    }
}
