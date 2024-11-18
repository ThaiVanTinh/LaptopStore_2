using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Infrastructure.Contexts;
using LaptopStore.Shared.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LaptopStore.Server.Controllers.v1.Catalog
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly BlazorHeroContext _dbContext;

        public OrderController(BlazorHeroContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("SaveOrder")]
        public async Task<IActionResult> SaveOrder([FromBody] Order order)
        {
            try
            {
                _dbContext.Orders.Add(order);
                await _dbContext.SaveChangesAsync();
                return Ok(await Result.SuccessAsync("Order saved successfully."));
            }
            catch (DbUpdateException ex)
            {
                return BadRequest(await Result.FailAsync("Database Update Error: " + ex.InnerException?.Message ?? ex.Message));
            }
            catch (System.Exception ex)
            {
                return BadRequest(await Result.FailAsync("Error saving order: " + ex.Message));
            }
        }
    }
}
