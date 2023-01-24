namespace CarFactory
{
    namespace Models
    {
        public class Vehicle
        {
            private string Color = string.Empty;
            private string Brand = string.Empty;

            public Vehicle(string color, string brand)
            {
                this.Color = color;
                this.Brand = brand;
            }

            public string GetVehicleColor()
            {
                return this.Color;
            }

            public string GetVehicleBrand()
            {
                return this.Brand;
            }
        }
    }
}