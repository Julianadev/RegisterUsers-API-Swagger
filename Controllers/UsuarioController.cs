using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTeste.Context;
using ApiTeste.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiTeste.Controllers
{
    public class UsuarioController  : ControllerBase
    {
        private readonly MeuContext _context;

        public UsuarioController(MeuContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("api/usuario")]
        public IActionResult Get()
        {
            return Ok(_context.Usuarios.ToList());
        }

        [HttpGet]
        [Route("api/usuario/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_context.Usuarios.Find(id));
        }

        [HttpPost]
        [Route("api/usuario")]
        public IActionResult Post([FromBody] Usuarios usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Ok(usuario);
        }

        [HttpPut]
        [Route("api/usuario/{id}")]
        public IActionResult Put(int id, [FromBody] Usuarios usuario)
        {
            _context.Entry(usuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok(usuario);
        }

        [HttpDelete]
        [Route("api/usuario/{id}")]
        public IActionResult Delete(int id)
        {
            _context.Usuarios.Remove(_context.Usuarios.Find(id));
            _context.SaveChanges();
            return Ok();
        }
    }
}