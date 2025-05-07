using Warsztat.DTOS;

namespace Warsztat.Services;

public class AppointmentService
{
    private readonly string _connectionString;
    public AppointmentService(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("Default") ?? string.Empty;
    }

    public async Task<CreateVisitRequestDto> GetVisitServices(int id)
    {
        var query  = 
            @"SELECT * 
              FROM Visit v 
              WHERE Id=@id
              JOIN Client c ON c.client_id = v.client_id
              JOIN Mechanic m ON m.mechanic_id = v.mechanic_id
              JOIN Visit_Service vs ON vs.visit_id = v.visit.id
              ";
    }
}