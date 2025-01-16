namespace RazorPages_CombineLists.Models
{
    public interface IDatabase
    {
        public List<Car> getAllCars();
        public void createCar(Car car);

        public List<Engine> getAllEngines();
    }
}
