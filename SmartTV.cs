namespace TVPackage
{
    public sealed class SmartTV : TV
    {
        public SmartTV() { setPrice(300); setType("Smart"); }

        internal double getPowerUsage() { return 5.5; } // set power usage for smart tv
        public override void getInfo() // info for smart tv includes power usage
        {
            Console.WriteLine("Price: " + getPrice());
            Console.WriteLine("Type: " + getType());
            Console.WriteLine("Power Usage: " + getPowerUsage());
        }
    }
}
