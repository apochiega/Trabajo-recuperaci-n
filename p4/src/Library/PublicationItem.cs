namespace Ucu.Poo.Defense
{
    public class PublicationItem : IPublicationItem
    {
        public Material Material { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public int SubTotal
        {
            get
            {
                return this.Quantity * this.Price;
            }
            set
            {
            }
        }

        public PublicationItem(Material material, int quantity, int price)
        {
            this.Material = material;
            this.Quantity = quantity;
            this.Price = price;
        }
    }
}