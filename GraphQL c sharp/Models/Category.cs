namespace GraphQL_c_sharp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Menu> Menus { get; set; }
    }
}