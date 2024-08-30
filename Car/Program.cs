class Program
{
    static void Main()
    {
        Car car1 = new Car { Name = "Car A", MaxMph = 150, Horsepower = 300, Price = 25000m };
        Car car2 = new Car { Name = "Car B", MaxMph = 160, Horsepower = 320, Price = 27000m };

      
        Console.WriteLine(car1.CompareTo(car2));

        Car carClone = (Car)car1.Clone();
        Console.WriteLine(carClone.Name); 

        Console.WriteLine(car1.Equals(carClone)); 

        CarComparer comparer = new CarComparer(CarComparer.CompareBy.Horsepower);
        Console.WriteLine(comparer.Compare(car1, car2)); 
    }
}
