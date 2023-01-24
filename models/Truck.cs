namespace CarFactory
{
    namespace Models
    {
        public class Truck : Vehicle
        {
            private string Model = string.Empty;
            private float Capacity;

            public Truck(string color, string brand, string model, float capacity) : base(color, brand)
            {
                this.Model = model;
                this.Capacity = capacity;
            }

            public string GetTruckModel()
            {
                return this.Model;
            }

            public float GetTruckCapacity()
            {
                return this.Capacity;
            }
        }
    }
}