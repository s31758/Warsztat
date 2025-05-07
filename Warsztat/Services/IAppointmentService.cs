using Warsztat.DTOS;
using Warsztat.Models;

namespace Warsztat.Services;

public interface IAppointmentService
{
    Task<CreateVisitRequestDto> GetVisitServices(int userId);
    Task AddVisitServices(visitServices visitServices);
}