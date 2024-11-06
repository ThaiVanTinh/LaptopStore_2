using LaptopStore.Application.Interfaces.Repositories;
using LaptopStore.Application.Features.Products.Queries.GetProductDetail;
using LaptopStore.Domain.Entities.Catalog;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

public class GetProductDetailByIdQuery : IRequest<GetProductsDetailResponse>
{
    public int ProductId { get; set; }

    public GetProductDetailByIdQuery(int productId)
    {
        ProductId = productId;
    }

    // Query Handler - Gộp chung bên trong Query
    public class Handler : IRequestHandler<GetProductDetailByIdQuery, GetProductsDetailResponse>
    {
        private readonly IUnitOfWork<int> _unitOfWork;

        public Handler(IUnitOfWork<int> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<GetProductsDetailResponse> Handle(GetProductDetailByIdQuery request, CancellationToken cancellationToken)
        {
            // Tìm sản phẩm theo ID
            var product = await _unitOfWork.Repository<Product>().GetByIdAsync(request.ProductId);

            // Kiểm tra nếu không tìm thấy sản phẩm
            if (product == null)
            {
                return null; // Trả về null nếu không tìm thấy sản phẩm
            }

            // Trả về thông tin chi tiết của sản phẩm
            return new GetProductsDetailResponse
            {
                Id = product.Id,
                Name = product.Name,
                Barcode = product.Barcode,
                Price = product.Price,
                Description = product.Description,
                Rate = product.Rate,
                Featured = product.Featured,
                Brand = product.Brand?.Name,  // Nếu có Brand, lấy tên Brand
                BrandId = product.BrandId,
                ImageDataURL = product.ImageDataURL
            };
        }

    }
}
