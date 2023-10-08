namespace SOLID
{
    public class VehicleService
    {
        public double FuelConsumption(Vehicle vehicle)
        {
            var consumption = vehicle.VehicleType switch
            {
                VehicleType.Bicycle => vehicle.Distance / vehicle.FuelEfficiency,
                VehicleType.Car => vehicle.Distance / (vehicle.FuelEfficiency * 1.2),
                VehicleType.Motorcycle => vehicle.Distance / (vehicle.FuelEfficiency * 0.8),
                VehicleType.Truck => vehicle.Distance / (vehicle.FuelEfficiency * 1.2),
                _ => 0
            };

            return consumption;
        }

    }
    public class Vehicle
    {
        public VehicleType VehicleType { get; set; }
        public double FuelEfficiency { get; set; }
        public double Distance { get; set; }
        public string Model { get; set; }
    }

    public enum VehicleType
    {
        Car = 0,
        Truck = 1,
        Motorcycle = 2,
        Bicycle = 3
    }



}



