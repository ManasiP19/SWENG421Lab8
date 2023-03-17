namespace TVPackage
{
    public class TV
    {
        private int price;
        private string type;

        public TV() { price = 200; type = "Regular"; }
        internal int getPrice() { return price; }
        internal void setPrice(int price) { this.price = price; }
        internal string getType() { return type; }
        internal void setType(string type) { this.type = type; }
        public virtual TV? replenishTV(int budget)
        {
            if (budget >= 400) { return new UltraHDTV(); }
            else if (budget >= 300) { return new SmartTV(); }
            else if (budget >= 200) { return new UltraHDTV(); }
            else return null;
        } 
        public virtual void getInfo()
        {
            Console.WriteLine("Price: " + getPrice());
            Console.WriteLine("Type: " + getType());
        }
    }
}
