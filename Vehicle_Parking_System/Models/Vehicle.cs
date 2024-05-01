namespace Vehicle_Parking_Management.Models
{
    public class Vehicle
    {
        public string VehicleType { get; set; }

        public string Floor { get; set; }

        public string RegisteredState { get; set; }

        public DateTime ParkedTime { get; set; }
    }
}
