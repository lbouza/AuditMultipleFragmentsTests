namespace DBService.Domain
{
    public abstract class RootClass:BaseEntity
    {
        public Discriminator Type { get; set; }
        public string PropertyOne { get; set; }
        public string PropertyTwo { get; set; }
    }
}