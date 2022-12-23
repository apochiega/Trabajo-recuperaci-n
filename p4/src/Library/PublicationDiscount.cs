using System;

namespace Ucu.Poo.Defense
{
    public class PublicationDiscount : IPublicationItem
    {

        public Material Material { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        private int amount;

        public int SubTotal
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
                if (amount > 0)
            {
                throw new ArgumentException("El valor tiene que ser negativo");
            }
            
            }
            
        }

        public PublicationDiscount(int amount)
        {
            this.SubTotal = amount;
            
        }
    }
}