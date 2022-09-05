namespace RepairManagement.API.Models.Entities
{
    public class TypeOfService : BaseEntity
    {
        public int RepairId { get; set; }
        public string Repair { get; set; }
        public int SparePartId { get; set; }
        public int SparePart { get; set; }

    }
}
