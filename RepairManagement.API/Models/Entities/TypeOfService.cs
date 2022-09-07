namespace RepairManagement.API.Models.Entities
{
    public class TypeOfService : BaseEntity
    {
        public int RepairId { get; set; }
        public Repair Repair { get; set; }
        public int SparePartId { get; set; }
        public SparePart SparePart { get; set; }

    }
}
