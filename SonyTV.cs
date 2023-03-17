namespace TVPackage
{
    public class SonyTV : TV, TV_IF
    {
        private string brand;

        public SonyTV() { setPrice(280); setType("Regular"); setBrand("Sony"); }
        internal string getBrand() { return brand; }
        public void setBrand(string brand) { this.brand = brand; }
        public override void getInfo() // sony tv info includes brand
        {
            Console.WriteLine("Price: " + getPrice());
            Console.WriteLine("Type: " + getType());
            Console.WriteLine("Brand: " + getBrand());
        }
    }
}
