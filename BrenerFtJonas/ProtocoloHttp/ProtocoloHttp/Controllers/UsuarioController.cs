using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProtocoloHttp.Controllers
{
    [Route("usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private static readonly List<Usuario> Usuarios = new List<Usuario>();
        [HttpGet]
        public ActionResult ConsultarUsuarios() => Ok(Usuarios);
        [HttpPost]
        public ActionResult Adicionar(Usuario usuario)
        {
            Usuarios.Add(usuario);
            return Ok($"Usuario {usuario.Nome} cadastrado com sucesso!");
        }
        [HttpGet]
        [Route("{codigo}")]
        public ActionResult ConsultarUsuario(int codigo)
        {
            var usuario = Usuarios.FirstOrDefault(u => u.Codigo == codigo);
            if (usuario == null)
            {
                return BadRequest("Usuário não encontrado.");
            }
            return Ok(usuario);
        }
        [HttpPut]
        [Route("{codigo}")]
        public ActionResult Editar(int codigo, Usuario usuario)
        {
            var usuarioParaEditar = Usuarios.FirstOrDefault(u => u.Codigo == codigo);
            if (usuarioParaEditar is null)
            {
                return BadRequest("Usuário nao encontrado.");
            }
            //usuarioParaEditar = new Usuario
            //{
               // Codigo = usuarioParaEditar.Codigo,
               // Nome = usuario.Nome,
               // Login = usuario.Login
           // };

            usuarioParaEditar.Login = usuario.Login;
           usuarioParaEditar.Nome = usuario.Nome;

            return Ok(usuarioParaEditar);
        }

        [HttpDelete]
        [Route("{codigo}")]
        public ActionResult Excluir(int codigo)
        {
var usuarioParaExcluir = Usuarios.FirstOrDefault(u => u.Codigo == codigo);

            if (usuarioParaExcluir is null)
            {
                return BadRequest("Usuário não encontrado!");
            }

            Usuarios.Remove(usuarioParaExcluir);

            return Ok ("Usuario excluido com sucesso!");
        }
    }
}