using Grand.Services.Catalog;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Grand.Api.Commands.Models.Catalog
{
    public class DeleteProductCategoryCommandHandler : IRequestHandler<DeleteProductCategoryCommand, bool>
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public DeleteProductCategoryCommandHandler(
            ICategoryService categoryService,
            IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public async Task<bool> Handle(DeleteProductCategoryCommand request, CancellationToken cancellationToken)
        {
            var product = await _productService.GetProductById(request.Product.Id, true);
            var productCategory = product.ProductCategories.FirstOrDefault(x => x.CategoryId == request.CategoryId);
            if (productCategory == null)
                throw new ArgumentException("No product category mapping found with the specified id");

            productCategory.ProductId = product.Id;
            await _categoryService.DeleteProductCategory(productCategory);

            return true;
        }
    }
}
