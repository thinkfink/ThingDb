namespace ThingDb.Web.Models.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid LocationId { get; set; }
        public Guid UserId { get; set; }
    }
}
