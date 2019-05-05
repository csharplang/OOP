namespace OOP.Interface.SimpleExample
{
    public static class Execute
    {
        public static void Run()
        {
            IBangladesh bangladesh = new Country();
            bangladesh.Bangladesh();

            ICanada canada = new Country();
            canada.Canada();


            INetherland netherland = new Country();
            netherland.Netherland();
        }
    }
}
