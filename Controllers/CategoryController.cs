using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

//endpoint => URL
//https://localhost:5001/
//http://localhost:5000/

//endpoint/categories
namespace Shop.Controllers
{
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        //endpoint/categories  (quando route do método estiver vazio, ele é acessado pelo route da classe)
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Get()
        {
            return Ok(new List<Category>());
        }

        [HttpGet]
        [Route("{id:int}")] //":int" declara que ele aceita apenas int para o campo id na chamada da requisição
        public async Task<ActionResult<Category>> GetById(int id)
        {
            return Ok(new Category());
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Category>> Post([FromBody]Category category) //"[FromBody]" define que o parâmetro que o método vai receber é do corpo da requisição
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(category);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Category>> Put(int id, [FromBody]Category category)
        {
            if (id != category.Id)
                return NotFound(new { Message = "Categoria não encontrada" });

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(category);
        }

        [HttpDelete]
        [Route("")]
        public async Task<ActionResult<Category>> Delete()
        {
            return Ok();
        }
    }
}