using System.ComponentModel.DataAnnotations;
using AutoMapper;
using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using LaptopStore.Shared.Constants.Application;
using System.Collections.Generic;
using System.Linq;

namespace LaptopStore.Application.Features.Orders.Commands.Create
{
    public partial class CreateOrderCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public string UserName { get; set; }
        public string UserPhone { get; set; }
        public string UserAddress { get; set; }

        public List<CartItem> OrderItem { get; set; } = new List<CartItem>();

        [Required]
        public int TotalPrice { get; set; }

        [Required]
        public string MethodPayment { get; set; }

        [Required]
        public string StatusOrder { get; set; }

        [Required]
        public bool IsPayment { get; set; }
    }

    internal class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<CreateOrderCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;

        public CreateOrderCommandHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IStringLocalizer<CreateOrderCommand> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = (IStringLocalizer<CreateOrderCommandHandler>)localizer;
        }

        public async Task<Result<int>> Handle(CreateOrderCommand command, CancellationToken cancellationToken)
        {
            if (command.Id == 0)
            {
                var order = _mapper.Map<Order>(command);

                order.OrderItem = command.OrderItem.Select(item => new CartItem
                {
                    ProductId = item.ProductId,
                    ProductName = item.ProductName,
                    ProductPrice = item.ProductPrice,
                    Quantity = item.Quantity,
                    ProductImage = item.ProductImage
                }).ToList();

                // Lưu đơn hàng vào cơ sở dữ liệu
                await _unitOfWork.Repository<Order>().AddAsync(order);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllOrdersCacheKey);

                // Trả về kết quả thành công
                return await Result<int>.SuccessAsync(order.Id, _localizer["Order Saved"]);
            }
            else
            {
                return await Result<int>.FailAsync(_localizer["Invalid Order Id"]);
            }
        }
    }
}
