namespace FoodDeliveryApp.Models
{
    public class MenuItem
    {
        public int MenuId { get; set; }
        public int RestaurantId { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
    }
}
