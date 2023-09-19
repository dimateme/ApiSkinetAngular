using Core.Entities;
using Core.Interfaces;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ProductRepository: IProductRepository
{
    
    private readonly StoreContext _context;
    /// <summary>
    /// Constructor for ProductRepository
    /// </summary>
    /// <param name="context"></param>
    public ProductRepository(StoreContext context)
    {
        _context = context;
    }
    /// <summary>
    /// Method to get a single product by id from the database
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<Product>GetProductByIdAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }
    /// <summary>
    /// method to get all product from the database
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<IReadOnlyList<Product>>GetProductsAsync()
    {
        return await _context.Products.ToListAsync();
    }
}