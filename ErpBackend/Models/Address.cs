namespace ErpBackend.Models
{
    public abstract class Address
    {
        public string HomeAddress { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
    }
}