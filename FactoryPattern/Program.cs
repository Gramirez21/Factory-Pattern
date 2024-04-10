namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select number of tires on your desired vehicle 2 or 4");
            int userInput = int.Parse(Console.ReadLine());
            IVehicle customerVehicle = VehicleFactory.GeteVehicle(userInput);
            customerVehicle.Drive();

        }
    }
}
