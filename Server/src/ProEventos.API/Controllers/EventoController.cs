using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .NET 5/6",
                Local = "Fortaleza-CE",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.ToString("dd/MM/yyyy"),
                ImagemURL = "Photo1.png"
            },
            new Evento (){
                EventoId = 2,
                Tema = "Angular 11 e .NET 5/6 e mais",
                Local = "Fortaleza-CE",
                Lote = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.ToString("dd/MM/yyyy"),
                ImagemURL = "Photo2.png"
            }
        };
    public EventoController()
    {
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "Método Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return "Método Put";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return "Método Delete";
    }
}
