namespace _37ArrayOfObjects;

public class ArrayOfObjects
{
    public static void Main(string[] args)
    {
        Car[] garage = new Car[3]; // all of the car objects below are part of this array
            
        Car car1 = new Car("Ford");
        Car car2 = new Car("Toyota");
        Car car3 = new Car("Porsche");

        garage[0] = car1; // car1 is at index 0
        garage[1] = car2; // car2 is at index 1
        garage[2] = car3; // car3 is at index 2

        Console.WriteLine(garage[0].model); // put variable name after the index you want to access.
        Console.WriteLine(garage[1].model); // put variable name after the index you want to access.
        Console.WriteLine(garage[2].model); // put variable name after the index you want to access.

        Car[] garage1 = { new Car("Mustang"), new Car("Lambo"), new Car("Porsche") };

        foreach (Car car in garage) // you can also do this
        {
            Console.WriteLine(car.model);
        }

        foreach (Car vehicle in garage1)
        {
            Console.WriteLine(vehicle.model);
        }
        
    }

    class Car
    {
        public String model;

        public Car(String model) // constructor
        {
            this.model = model;
        }

        public void go()
        {
            Console.WriteLine($"{model} is going 60 km/h");
        }
    }
}