using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cqrs_parttern.Application.Abstractions;
using cqrs_parttern.Application.Product.Queries;
using MediatR;

namespace cqrs_parttern.Application.Product.QueryHandlers
{
    // IRequestHandler với ProductByIdQuery là 1 class chứa thông tin xử lí cần thiết
    /// <summary>
    /// Domain.Product là kiểu trả về cửa handler ProductByIdHandler
    /// </summary>
    public class ProductByIdHandler : IRequestHandler<ProductByIdQuery, Domain.Product>
    {
        private readonly IProductRepository _IProductRepository;
        public ProductByIdHandler(IProductRepository IProductRepository){
             this._IProductRepository = IProductRepository;
        }
        // Handle là nới chứa logic xử lí của ta 
        // CancellationToken là 1 token để hủy bỏ request khi cần thiết
        //ProductByIdQuery là 1 class chứa thông tin xử lí cần thiết
        public async Task<Domain.Product> Handle(ProductByIdQuery request, CancellationToken cancellationToken)
        {
          return await _IProductRepository.getProductById(request.productId);
        }
    }
}