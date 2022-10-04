namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many wheels does your vehcle need?");
            int wheelAmount = int.Parse( Console.ReadLine() );
             
            IVehicle vehicle = VehicleFactory.GetVehicle(wheelAmount);
            vehicle.Drive();
        }
    }
}