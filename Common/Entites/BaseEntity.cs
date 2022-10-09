namespace Common.Entites
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreationData { get; set; }
        public byte[] ConcurrencyStamp { get; set; }
    }
}
