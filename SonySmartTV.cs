namespace TVPackage
{
    public class SonySmartTV : SonyTV, SmartTV_IF
    {
        public SonySmartTV() { setPrice(380); setType("Smart"); }
        
        public double getPowerUsage() { return 5.15; } // power usage for sony smart tv

        public override void getInfo() // sony smart tv info includes brand and power usage
        {
            Console.WriteLine("Price: " + getPrice());
            Console.WriteLine("Type: " + getType());
            Console.WriteLine("Brand: " + getBrand());
            Console.WriteLine("Power Usage: " + getPowerUsage());
        }
    }
}
