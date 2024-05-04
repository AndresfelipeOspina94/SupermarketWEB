namespace SupermarketWEB.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
