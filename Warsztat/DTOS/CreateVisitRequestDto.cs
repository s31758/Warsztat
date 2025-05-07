using Warsztat.Models;

namespace Warsztat.DTOS;

public class CreateVisitRequestDto
{
    public int ID {get; set;}
    public client Client {get; set;}
    public mechanic mechanic {get; set;}
    
}