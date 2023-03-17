namespace TVPackage
{
    public class SonyUltraHDTV : SonyTV, UltraHDTV_IF
    {
        public SonyUltraHDTV() { setPrice(480); setType("UltraHD"); }
    }
}
