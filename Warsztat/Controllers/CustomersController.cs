using Microsoft.AspNetCore.Mvc;
using Warsztat.Services;

namespace Warsztat.Controllers;
[Microsoft.AspNetCore.Components.Route("api/[controller]")]
[ApiController]
public class CustomersController
{
    private readonly AppointmentService _appointmentService;

    public CustomersController(AppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    [HttpGet("api/visits/{id} ")]
    public async Task<IActionResult> GetCustomerVisits(int id)
    {
        
    }
        
}