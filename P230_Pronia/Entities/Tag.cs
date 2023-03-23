namespace P230_Pronia.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BlogTags> BlogTags { get; set; }
    }
}
