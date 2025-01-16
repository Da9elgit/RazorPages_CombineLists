namespace RazorPages_CombineLists.Models
{
    public class Database : IDatabase
    {
        List<Car> carList;
        int carId = 0;
        string[] carNames = { "TOYOTA", "Ford", "Volkswagen", "AG", "BMW", "Honda", "Nissan", "Tesla", "Mercedes Benz", "General Motors", "Hyundai", "Porsche", "Chevrolet", "Ferrari", "Mazda", "BYD", "Lexus", "Audi", "SAIC Motor", "Stellantis", "Subaru", "Aston Martin", "Bentley", "Bugatti", "Kia" };
        public Database()
        {
            if (carList == null)
            {
                Random random = new Random();
                carList = new List<Car>();
                for (int i = 0; i < 10; i++)
                {
                    Car car = new Car();
                    car.Id = carId++;
                    car.Name = carNames[random.Next(carNames.Length)];
                    carList.Add(car);
                }
            }
        }

        public List<Car> getAllCars()
        {
            return carList;
        }
    }
}
