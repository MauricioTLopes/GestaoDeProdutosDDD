using GestaoDeProdutosDDD.Application.Dtos;
using GestaoDeProdutosDDD.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace GestaoDeProdutosDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IApplicationServiceProduto applicationServiceProduto;

        public ProdutosController(IApplicationServiceProduto applicationServiceProduto)
        {
            this.applicationServiceProduto = applicationServiceProduto;
        }

        // GET api/values/5\
        [HttpGet("RecuperarRegistro{id}")]
        public ActionResult<string> Get(int id)
        {
            var result = applicationServiceProduto.GetById(id);

            if(result.Id > 0)
                return Ok(applicationServiceProduto.GetById(id));
            else return NotFound();
        }

        // GET api/values
        [HttpGet("ListarRegistro{qnt}")]
        public ActionResult<IEnumerable<string>> GetAll(int qnt)
        {
            return Ok(applicationServiceProduto.GetAll(qnt));
        }

        // POST api/values
        [HttpPost("InserirRegistro")]
        public ActionResult Post([FromBody] ProdutoDTO produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                if (produtoDTO.DataFabricacao >= produtoDTO.DataValidade)
                    return BadRequest("A data de fabricação não poderá ser maior ou igual a data de validade.");

                applicationServiceProduto.Add(produtoDTO);
                return Ok("O produto foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut("EditarRegistro")]
        public ActionResult Put([FromBody] ProdutoDTO produtoDTO)
        {

            try
            {
                if (produtoDTO == null)
                    return NotFound();

                if (produtoDTO.DataFabricacao >= produtoDTO.DataValidade)
                    return BadRequest("A data de fabricação não poderá ser maior ou igual a data de validade.");

                applicationServiceProduto.Update(produtoDTO);
                return Ok("O produto foi atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete("ExcluirRegistro")]
        public ActionResult Delete([FromBody] ProdutoDTO produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                produtoDTO.Situacao = false;

                applicationServiceProduto.Update(produtoDTO);
                return Ok("O produto foi situado como inativo com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}