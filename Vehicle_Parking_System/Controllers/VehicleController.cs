using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vehicle_Parking_Management.Services;

namespace Vehicle_Parking_Management
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet("getAllVehicle")]
        public async Task<IActionResult> GetAllVehicle()
        {
            var vehicle=await _vehicleService.getAllVehicles();
            return Ok("success");
        }
    }
}
