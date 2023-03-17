namespace TVPackage
{
    public class VizioSmartTV : VizioTV, SmartTV_IF
    {
        public VizioSmartTV() { setPrice(350); setType("Smart"); }
        internal double getPowerUsage() { return 6.35; } // power usage for vizio smart tv 
        public override void getInfo() // vizio smart tv info oncludes brand and power usage
        {
            Console.WriteLine("Price: " + getPrice());
            Console.WriteLine("Type: " + getType());
            Console.WriteLine("Brand: " + getBrand());
            Console.WriteLine("Power Usage: " + getPowerUsage());
        }
    }
}
