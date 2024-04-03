using EiSys.CleanArchitecture.ApplicationLayer.Contracts;
using EiSys.CleanArchitecture.DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EiSys.CleanArchitecture.WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionario funcionario;

        public FuncionarioController(IFuncionario funcionario)
        {
            this.funcionario = funcionario;
        }
        // GET: api/<FuncionarioController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await funcionario.GetAsync();
            return Ok(data);
        }

        // GET api/<FuncionarioController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var data = await funcionario.GetByIdAsync(id);
            return Ok(data);
        }

        // POST api/<FuncionarioController>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Funcionario funcionarioDto)
        {
            var result = await funcionario.AddAsync(funcionarioDto);
            return Ok(result);
        }

        // PUT api/<FuncionarioController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] Funcionario funcionarioDto)
        {
            var result = await funcionario.UpdateAsync(funcionarioDto);
            return Ok(result);
        }

        // DELETE api/<FuncionarioController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await funcionario.DeleteAsync(id);
            return Ok(result);
        }
    }
}
