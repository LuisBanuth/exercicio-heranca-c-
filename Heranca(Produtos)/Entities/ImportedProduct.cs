namespace Heranca_Produtos_.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name + " $" + TotalPrice() + " (Custom Fee: $" + CustomsFee + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
