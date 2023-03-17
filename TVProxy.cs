namespace TVPackage
{
    public class TVProxy : TV, TV_IF
    {
        public TV tv;
        public TV_IF tvif;

        public override TV? replenishTV(int budget)
        {
            if (budget >= 480) { return new SonyUltraHDTV(); }
            else if (budget >= 450) { return new VizioUltraHDTV(); }
            else if (budget >= 400) { return new UltraHDTV(); }
            else if (budget >= 380) { return new SonySmartTV(); }
            else if (budget >= 350) { return new VizioSmartTV(); }
            else if (budget >= 300) { return new SmartTV(); }
            else if (budget >= 280) { return new SonyTV(); }
            else if (budget >= 250) { return new VizioTV(); }
            else if (budget >= 200) { return new TV(); }
            else return null;
        }
    }
}
