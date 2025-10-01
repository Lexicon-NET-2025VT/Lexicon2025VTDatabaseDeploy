namespace Lexicon2025VTDatabaseDeploy.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int Year { get; set; }

        public int VehicleTypeId { get; set; }

        public VehicleType VehicleType { get; set; }

        public int NrOfWheels { get; set; }
    }
}
