using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository
{
    /// <summary>
    /// Method to get a single product by id from the database
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<Product> GetProductByIdAsync(int id);
    
    /// <summary>
    /// Method to get all product from the database
    /// </summary>
    /// <returns></returns>
    Task<IReadOnlyList<Product>>GetProductsAsync();
}