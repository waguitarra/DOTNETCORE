﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.WebAPI.Model;


namespace ProAgil.WebAPI.Controllers
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
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular e .NET Core",
                    Local = "Belo Horizonte",
                    Lote = "1ª Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular e sua novidades",
                    Local = "Sao paulo",
                    Lote = "2ª Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return new Evento[] { 
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular e .NET Core",
                    Local = "Belo Horizonte",
                    Lote = "1ª Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular e sua novidades",
                    Local = "Sao paulo",
                    Lote = "2ª Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
            }.FirstOrDefault(x => x.EventoId == id);
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
