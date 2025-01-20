using System;

namespace RazorPages_CombineLists.Models
{
    public class Database : IDatabase
    {
        List<Car> carList;
        int carId = 0;
        List<Engine> engineList;
        int engineId = 0;
        Random random = new Random();
        string[] carBrands = { "TOYOTA", "Ford", "Volkswagen", "AG", "BMW", "Honda", "Nissan", "Tesla", "Mercedes Benz", "General Motors", "Hyundai", "Porsche", "Chevrolet", "Ferrari", "Mazda", "BYD", "Lexus", "Audi", "SAIC Motor", "Stellantis", "Subaru", "Aston Martin", "Bentley", "Bugatti", "Kia" };
        string[] carOwners = { "James", "Michael", "Robert", "John", "David", "William", "Richard", "Joseph", "Thomas", "Christopher", "Charles", "Daniel", "Matthew", "Anthony", "Mark", "Steven", "Andrew", "Paul", "Joshua", "Kenneth", "Kevin", "Brian", "Timothy", "Ronald", "George", "Jason", "Edward" };
        public Database()
        {
            if (carList == null)
            {              
                carList = new List<Car>();
                engineList = new List<Engine>();
                for (int i = 0; i < 10; i++)
                {
                    Engine engine = new Engine();
                    engine.Id = engineId++;
                    engine.DistanceKørtKm = random.Next(500000);                    
                    engineList.Add(engine);

                    Car car = new Car();
                    car.Id = carId++;
                    car.Brand = carBrands[random.Next(carBrands.Length)];
                    car.OwnerName = carOwners[random.Next(carOwners.Length)];

                    car.Engine = engineList[i];
                    carList.Add(car);                    
                }
            }
        }

        public List<Car> getAllCars()
        {
            return carList;
        }

        public void createCar(Car car, int engineIndex)
        {
            car.Id = carId++;
            car.Engine = engineList[engineIndex];
            
            carList.Add(car);
        }

        public void addEngine(Engine engine)
        {
            engine.Id = engineId++;            
            engineList.Add(engine);
        }

        public List<Engine> getAllEngines()
        {
            return engineList;
        }

    }
}
