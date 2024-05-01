using Vehicle_Parking_Management.Models;

namespace Vehicle_Parking_Management.Services
{
    public interface IVehicleService
    {
        Task<List<Vehicle>> getAllVehicles();

        Task<List<Vehicle>> getVehicles(string vehicleId);


    }
}
