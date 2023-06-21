using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_test.Domain;
using aula14_ef_repositories.Data.Repositories;
using aula14_ef_repositories.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aula14_ef_repositories.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuppliersController : ControllerBase
    {
        private readonly ISupplierRepository repositiory;

        public SuppliersController()
        {
            this.repositiory = new SupplierRepository();
        }

        [HttpGet]
        public IEnumerable<Supplier>Get()
        {
            return repositiory.GetAll();
        }
        [HttpGet("{id}")]
        public Supplier Get(int id)
        {
            return repositiory.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Supplier item)
        {
            repositiory.Save(item);
            return Ok( new {
                statusCode=200,
                message = "Cadastrado com sucesso",
                item
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repositiory.Delete(id);
            return Ok( new {
                statusCode=200,
                message = "Pessoa excluída com sucesso"
            });
        }
        [HttpPut]
        public IActionResult Put([FromBody]Supplier item)
        {
            repositiory.Update(item);
            return Ok( new {
                statusCode=200,
                message = item.Name + " atualizado com sucesso",
                item
            });
        }
    }
}