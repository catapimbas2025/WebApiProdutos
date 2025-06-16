using Microsoft.AspNetCore.Mvc;
using WebApiProdutos.Models;

namespace WebApiProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : Controller
    { 
        
            private static List<Produto> _produtos = new List<Produto>
            {
                new Produto { Id = 1, Nome = "Notebook", Preco = 3500.00m, Estoque = 10 },
                new Produto { Id = 2, Nome = "Mouse", Preco = 50.00m, Estoque = 30 },
                new Produto { Id = 3, Nome = "Teclado", Preco = 120.00m, Estoque = 15 },
            };
            [HttpGet]
            public IActionResult Get()
            {
                return Ok(_produtos);
            }

            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                var produto = _produtos.FirstOrDefault(p => p.Id == id);
                if (produto == null)                
                return NotFound();
                return Ok(produto);
            }

            [HttpPost]
            public IActionResult Post(Produto produto)
            {
                produto.Id= _produtos.Max(p => p.Id) + 1;
                _produtos.Add(produto);
                return CreatedAtAction(nameof(GetById), new { id = produto.Id }, produto);
            }

            [HttpPut("{id}")]
            public IActionResult Put(int id, Produto produto)
            {
                var existingProduto = _produtos.FirstOrDefault(p => p.Id == id);
                if (existingProduto == null)
                return NotFound();
                existingProduto.Nome = produto.Nome;
                existingProduto.Preco = produto.Preco;
                existingProduto.Estoque = produto.Estoque;
                return NoContent();
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                var produto = _produtos.FirstOrDefault(p => p.Id == id);
                if (produto == null)
                    return NotFound();
                _produtos.Remove(produto);
                return NoContent();
            }

        }
    }

