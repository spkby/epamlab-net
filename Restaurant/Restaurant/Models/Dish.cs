namespace Restaurant.Models
{
    public class Dish
    {
        public string title { get; }
        public string desc { get; }
        public int price { get; }

        public Dish(string title, string desc, int price)
        {
            this.title = title;
            this.desc = desc;
            this.price = price;
        }
    }
}