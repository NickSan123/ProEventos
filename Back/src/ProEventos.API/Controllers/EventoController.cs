using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
        public readonly DataContex _contex;
        public EventoController(DataContex contex)
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
                _evento => _evento.EventoID == id
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

