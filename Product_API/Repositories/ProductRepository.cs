using Product.Domain.Entities;

namespace Product_API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<ProductModel> _products;

        public ProductRepository()
        {
            _products = new List<ProductModel>();
        }

        public ProductModel Add(ProductModel product)
        {
            _products.Add(product);
            return product;
        }

        public List<ProductModel> GetAll()
        {
            return _products;
        }
    }
}
