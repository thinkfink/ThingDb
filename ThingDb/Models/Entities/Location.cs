namespace ThingDb.Web.Models.Entities
{
    public class Location
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int ItemCount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public Guid UserId { get; set; }
    }
}
