namespace TVPackage
{
    public class VizioTV : TV, TV_IF
    {
        string brand;

        public VizioTV() { setPrice(250); setType("Regular"); setBrand("Vizio"); }
        internal string getBrand() { return brand; }
        internal void setBrand(string brand) { this.brand = brand; }
        public override void getInfo() // vizio tv info includes brand
        {
            Console.WriteLine("Price: " + getPrice());
            Console.WriteLine("Type: " + getType());
            Console.WriteLine("Brand: " + getBrand());
        }
    }
}
