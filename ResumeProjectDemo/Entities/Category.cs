namespace ResumeProjectDemo.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public string DataFilter { get; set; }


    }
}
