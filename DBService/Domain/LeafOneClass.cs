namespace DBService.Domain
{
    public class LeafOneClass:RootClass
    {
        public LeafOneClass()
        {
            Type = Discriminator.LeafOne;
        }
        public string PropertyFour { get; set; }
    }
}