using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Domain;
using ProEventos.Persistence;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        
        public readonly ProEventosContext _contex;
        public EventosController(ProEventosContext contex)
        {
            _contex = contex;
        }
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _contex.Eventos;
        }
        [HttpGet("{id}")]
        public Evento GetByID(int id)
        {
            return _contex.Eventos.FirstOrDefault(
                _evento => _evento.Id == id
                );
        }
        [HttpPost]
        public string Post()
        {
            return "Exemplo POST";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Exemplo Put com id= " + id;
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Exemplo Delete com id= " + id;
        }
    }
}

