namespace Pharma.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public List<MedicineOrder> Medicines { get; set; } = new();
        public decimal TotalPrice { get; set; }
    }
}

public class MedicineOrder
{
    public int Id { get; set; }
    public int MedicineId { get; set; }
    public int Quantity { get; set; }
}

