namespace Sefu
{
    internal class Program
    {
        static void Main()
        {
            SafeOwner owner = new SafeOwner();
            Safe safe = new Safe();
            JewelThief jewelThief = new JewelThief();
            jewelThief.OpenSafe(safe, owner);
        }
    }
}
