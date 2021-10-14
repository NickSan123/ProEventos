using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
            {
                new Evento()
                {
                    EventoID = 1,
                    Local = "Pedreira",
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    Tema = "Assalto",
                    QtdPessoas = 30,
                    Lote = "Rumo ao milhão",
                    ImageURL = "https://istoe.com.br/wp-content/uploads/sites/14/2021/08/refem-aracatuba-assalto-carro.jpg"
                },
                new Evento()
                {
                    EventoID = 2,
                    Local = "Banco do Brasil",
                    DataEvento = DateTime.Now.AddDays(5).ToString(),
                    Tema = "Arrombamnto",
                    QtdPessoas = 30,
                    Lote = "Rumo ao milhão",
                    ImageURL = "https://istoe.com.br/wp-content/uploads/sites/14/2021/08/refem-aracatuba-assalto-carro.jpg"
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
        public IEnumerable<Evento> GetByID(int id)
        {
            return _evento.Where(_evento => _evento.EventoID == id);
        }
        [HttpPost]
        public string Post()
        {
            return "Exemplo POST";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Exemplo Put com id= "+ id;
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Exemplo Delete com id= "+ id;
        }
    }
}

