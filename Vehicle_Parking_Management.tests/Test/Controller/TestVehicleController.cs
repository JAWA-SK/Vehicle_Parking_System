using FluentAssertions;
using Moq;
using Vehicle_Parking_Management.Models;
using Vehicle_Parking_Management.Services;

namespace Vehicle_Parking_Management.tests.Test.Controller
{
    public class TestVehicleController
    {
        [Fact]
        public async Task shouldReturnAllVehicle_WithStatusOk()
        {
            var mockVehicleService =new Mock<IVehicleService>();
            mockVehicleService.Setup(service => service.getAllVehicles()).
                ReturnsAsync(new List<Vehicle>());

            var testController = new VehicleController(mockVehicleService.Object);
            var result =await testController.GetAllVehicle();

            mockVehicleService.Verify(service=>service.getAllVehicles(),Times.Once());
          


        }
    }
}