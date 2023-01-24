namespace CarFactory
{
    namespace Models
    {
        public class Cars : Vehicle
        {
            private string Model = string.Empty;

            public Cars(string color, string brand, string model) : base(color, brand)
            {
                this.Model = model;
            }

            public string GetCarModel()
            {
                return this.Model;
            }
        }
    }
}