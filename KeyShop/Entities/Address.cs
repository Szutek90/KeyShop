namespace KeyShop.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }

        public virtual User User { get; set; }
    }
}
