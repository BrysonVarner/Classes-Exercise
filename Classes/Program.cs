namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Hyundai";
            myCar.Model = "Elantra";
            myCar.Year = 2022;

            var myTruck = new Car() { Make = "Chevy", Model = "S-10", Year = 1996 };

            var myOldCar = new Car("Ford", "Probe", 1997);
            
            var carList = new List<Car>() {myCar, myTruck, myOldCar };

            Console.WriteLine("  Car Make  || Car Model  || Vehicle Year  ");
            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} || {vehicle.Model} || {vehicle.Year}");
            }
            
        }
    }
}
