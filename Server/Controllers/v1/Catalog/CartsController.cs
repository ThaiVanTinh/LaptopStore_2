using LaptopStore.Application.Features.Carts.Queries.GetAll;
using LaptopStore.Application.Features.Carts.Queries.GetById;
using LaptopStore.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using LaptopStore.Application.Features.Carts.Commands.AddEdit;
using LaptopStore.Application.Features.Carts.Commands.Delete;
using LaptopStore.Application.Features.Carts.Queries.Export;

namespace LaptopStore.Server.Controllers.v1.Catalog
{
    public class CartsController : BaseApiController<CartsController>
    {

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var carts = await _mediator.Send(new GetAllCartsQuery());
            return Ok(carts);
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cart = await _mediator.Send(new GetCartByIdQuery() { Id = id });
            return Ok(cart);
        }

        [Authorize(Policy = Permissions.Carts.Create)]
        [HttpPost]
        public async Task<IActionResult> Post(AddEditCartCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [Authorize(Policy = Permissions.Carts.Delete)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteCartCommand { Id = id }));
        }

        [Authorize(Policy = Permissions.Carts.Export)]
        [HttpGet("export")]
        public async Task<IActionResult> Export(string searchString = "")
        {
            return Ok(await _mediator.Send(new ExportCartsQuery(searchString)));
        }
    }
}