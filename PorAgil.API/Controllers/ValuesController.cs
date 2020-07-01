using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PorAgil.API.Model;

namespace PorAgil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[] { 

                new Evento() {
                    EventoID = 1,
                    Local = "Americana",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    Tema = "Angular e AspNet",
                    QtdePessoas = 100,
                    Lote = "2º Lote"
                },

                new Evento() {
                    EventoID = 2,
                    Local = "Campinas",
                    DataEvento = DateTime.Now.AddDays(6).ToString("dd/MM/yyyy"),
                    Tema = "React NodeJS",
                    QtdePessoas = 150,
                    Lote = "1º Lote"
                }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
             return new Evento[] { 

                new Evento() {
                    EventoID = 1,
                    Local = "Americana",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    Tema = "Angular e AspNet",
                    QtdePessoas = 100,
                    Lote = "2º Lote"
                },

                new Evento() {
                    EventoID = 2,
                    Local = "Campinas",
                    DataEvento = DateTime.Now.AddDays(6).ToString("dd/MM/yyyy"),
                    Tema = "React NodeJS",
                    QtdePessoas = 150,
                    Lote = "1º Lote"
                }
            }.FirstOrDefault(x => x.EventoID == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
