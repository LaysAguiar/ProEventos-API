using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventController : ControllerBase
{
public IEnumerable<Event> _event = new Event[] {
            new Event() {
                EventId = 1,
                EventAdress = "Rua do Evento 1",
                EventDate = DateTime.Now.ToString("dd/MM/yyyy"),
                EventTheme = "Evento de Tecnologia",
                QuantityPeople = 250,
                EventLote = "1º Lote",
                ImageURL = "foto.jpg"
            },
               new Event() {
                EventId = 2,
                EventAdress = "Rua do Evento 2",
                EventDate = DateTime.Now.AddDays(10).ToString("dd/MM/yyyy"),
                EventTheme = "Evento de Tecnologia",
                QuantityPeople = 250,
                EventLote = "2º Lote",
                ImageURL = "foto.jpg"
            },
        };

     public EventController()
    {
    }

    [HttpGet]
    public IEnumerable<Event> Get()
    {
        return _event;
        
    }


    [HttpGet("{id}")]
    public IEnumerable<Event> GetById(int id)
    {
        return _event.Where(events => events.EventId == id);
        
    }

    [HttpPost]
    public string Post()
    {
        return "Example of Post"; 
    }

    [HttpPatch("{id}")] 
    public string Patch(int id)
    {
        return $"Example of Patch for ID: {id}"; 
    }

    [HttpPut("{id}")] 
    public string Put(int id)
    {
        return $"Example of Put for ID: {id}"; 
    }

    [HttpDelete("{id}")] 
    public string Delete(int id)
    {
        return $"Example of Delete for ID: {id}"; 
    }
}
