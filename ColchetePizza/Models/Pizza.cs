namespace ContosoPizza.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsGlutenFree { get; set; }
        public int Slices { get; set;}
        public int Weight { get; set;}
    }
}