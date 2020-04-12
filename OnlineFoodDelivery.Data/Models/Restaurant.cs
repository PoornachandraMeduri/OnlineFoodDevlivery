namespace OnlineFoodDelivery.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public CousinTypes  Cousin { get; set; }
    }
}
