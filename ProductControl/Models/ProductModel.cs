namespace ProductControl.Models
{
    public class ProductModel
    {
        public Int64? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string BarCode { get; set; } = string.Empty;
        public DateTime ValidityDate { get; set; }
        public DateTime RegistryDate { get; set; }
        public int Quantity { get; set; }
        public Decimal Price { get; set; }
        public string PhotoName { get; set; }
        public byte[] Photo { get; set; }
        public bool Active { get; set; }

    }
}
