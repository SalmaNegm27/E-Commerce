namespace ECommerce.Application
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameSecondLanguage { get; set; }
        public DateTime CreationData { get; set; }
    }
}
