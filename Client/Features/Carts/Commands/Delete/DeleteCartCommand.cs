using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Domain.Entities.Catalog;
using LaptopStore.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
<<<<<<< HEAD
=======
using LaptopStore.Shared.Constants.Application;
>>>>>>> 9d7f1a9 (cart)

namespace LaptopStore.Application.Features.Carts.Commands.Delete
{
    public class DeleteCartCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
    }

    internal class DeleteCartCommandHandler : IRequestHandler<DeleteCartCommand, Result<int>>
    {
<<<<<<< HEAD
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IStringLocalizer<DeleteCartCommandHandler> _localizer;

        public DeleteCartCommandHandler(IUnitOfWork<int> unitOfWork, IStringLocalizer<DeleteCartCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
=======
        private readonly IProductRepository _productRepository;
        private readonly IStringLocalizer<DeleteCartCommandHandler> _localizer;
        private readonly IUnitOfWork<int> _unitOfWork;

        public DeleteCartCommandHandler(IUnitOfWork<int> unitOfWork, IProductRepository productRepository, IStringLocalizer<DeleteCartCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _productRepository = productRepository;
>>>>>>> 9d7f1a9 (cart)
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(DeleteCartCommand command, CancellationToken cancellationToken)
<<<<<<< HEAD
        {
            var cart = await _unitOfWork.Repository<Product>().GetByIdAsync(command.Id);
            if (cart != null)
            {
                await _unitOfWork.Repository<Product>().DeleteAsync(cart);
                await _unitOfWork.Commit(cancellationToken);
=======
        {            
            var cart = await _unitOfWork.Repository<Cart>().GetByIdAsync(command.Id);
            if (cart != null)
            {
                await _unitOfWork.Repository<Cart>().DeleteAsync(cart);
                await _unitOfWork.CommitAndRemoveCache(cancellationToken, ApplicationConstants.Cache.GetAllCartsCacheKey);
>>>>>>> 9d7f1a9 (cart)
                return await Result<int>.SuccessAsync(cart.Id, _localizer["Cart Deleted"]);
            }
            else
            {
                return await Result<int>.FailAsync(_localizer["Cart Not Found!"]);
<<<<<<< HEAD
            }
=======
            }           
>>>>>>> 9d7f1a9 (cart)
        }
    }
}