// using JsonPatch.JsonPatchDocument;
using ModuloAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloAPI.Controllers
{

    private static readonly string[] STATUS = new string[]
    {
        "Aguardando Pagamento",
        "Pagamento Aprovado",
        "Entregue",
        "Cancelada"
    };

    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        public VendaController()
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            // app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<string>> OperacaoRegistarVenda()
        {
            Venda venda = new Venda();
            return venda.STATUS[0];
        } // end method

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> OperacaoBuscarVenda()
        {
            if (vendas.Any())
                return NotFound();
            return Ok(vendas);
        } // end method

        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status205OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> OperacaoAtualizarVenda(
            string id,
            JsonPatchDocument<Venda> vendaUpdates
        )
        {
            // Updating data with JsonPatch [13 of 18] | Web APIs for Beginners https://youtu.be/2MDlJRa4iHs

            var venda = await _vendaData.GetVendaById(id);

            if (venda == null)
                return NotFound();

            vendaUpdates.ApplyTo(venda);
            return noContent();
        } // end method

        // https://learn.microsoft.com/pt-br/aspnet/core/migration/webapi?view=aspnetcore-6.0&tabs=visual-studio
        [HttpGet]
        public IEnumerable<Venda> GetAllVendas()
        {
            Venda[] vendas = new Venda[]
            {
                new Venda
                {
                    Id = 1,
                    Name = "Tomato Soup",
                    Category = "Groceries",
                    Price = 1
                },
                new Venda
                {
                    Id = 2,
                    Name = "Yo-yo",
                    Category = "Toys",
                    Price = 3.75M
                },
                new Venda
                {
                    Id = 3,
                    Name = "Hammer",
                    Category = "Hardware",
                    Price = 16.99M
                }
            };
            if (vendas.Any())
                return NotFound();
            return Ok(vendas);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Venda> GetVenda(int id)
        {
            Venda[] vendas = new Venda[]
            {
                new Venda
                {
                    Id = 1,
                    Name = "Tomato Soup",
                    Category = "Groceries",
                    Price = 1
                },
                new Venda
                {
                    Id = 2,
                    Name = "Yo-yo",
                    Category = "Toys",
                    Price = 3.75M
                },
                new Venda
                {
                    Id = 3,
                    Name = "Hammer",
                    Category = "Hardware",
                    Price = 16.99M
                }
            };

            var venda = vendas.FirstOrDefault((p) => p.Id == id);
            if (venda == null)
            {
                return NotFound();
            }
            return venda;
        }
    }
}
