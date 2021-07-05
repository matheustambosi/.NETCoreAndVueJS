using Microsoft.AspNetCore.Mvc;
using MVCBaseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCBaseProject.Controllers
{
    //https://localhost:44358/pessoa
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public List<PessoaModel> GetAll()
        {
            var pessoas = new List<PessoaModel>();

            pessoas.Add(new PessoaModel
            {
                Nome = "Matheus Tambosi",
                Documento = "111.111.111.11",
                Idade = 19
            });
            pessoas.Add(new PessoaModel
            {
                Nome = "João Tomio",
                Documento = "222.222.222.22",
                Idade = 19
            });
            pessoas.Add(new PessoaModel
            {
                Nome = "Vitor Adriel",
                Documento = "333.333.333.33",
                Idade = 19
            });
            pessoas.Add(new PessoaModel
            {
                Nome = "João Artur",
                Documento = "444.444.444.44",
                Idade = 19
            });

            return pessoas;
        }
    }
}
