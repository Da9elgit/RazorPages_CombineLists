namespace RazorPages_CombineLists.Models
{
    public interface IDatabase
    {
        public List<Car> getAllCars();
        public void createCar(Car car, int engineIndex);
        public void addEngine(Engine engine);

        public List<Engine> getAllEngines();       

    }
}
