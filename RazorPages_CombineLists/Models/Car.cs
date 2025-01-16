namespace RazorPages_CombineLists.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string OwnerName { get; set; }
        public ICollection<Engine>? Engine { get; } = new List<Engine>();
    }
}
