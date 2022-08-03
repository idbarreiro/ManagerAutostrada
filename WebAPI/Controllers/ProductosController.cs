using Application.Features.Productos.Commands.CreateProductoCommand;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        //POST api/<controller>
        [HttpPost]
        public async Task<ActionResult> Post(CreateProductoCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
