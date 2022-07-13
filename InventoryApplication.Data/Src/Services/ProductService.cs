using Crystal.Sms.Core.Helper;
using InventoryApplication.Dto;
using InventoryApplication.Exceptions;
using InventoryApplication.Models.Entity;
using InventoryApplication.Repository.RepositoryInterface;
using InventoryApplication.Services.ServicesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace InventoryApplication.Services
{
    public class ProductService:ProductServiceInterface
    {
        readonly ProductRepositoryInterface _productReop;
        public ProductService(ProductRepositoryInterface productRepo)
        {
            _productReop = productRepo;
        }
        public async Task CreateAsync(ProductDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            List<Product> productList = await _productReop.GetAllAsync();
            if (productList.Any(p => p.Name == dto.Name && p.Weight == dto.Weight))
            {
                throw new DuplicateEntryException();
            }
            var product = new Product(dto.Name,dto.Weight);
            await _productReop.InsertAsync(product);
            scope.Complete();
        }

        public async Task UpdateAsync(ProductUpdateDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var product = await _productReop.GetByIdAsync(dto.Id);
            product.Update(dto.Name, dto.Weight, dto.Quantity);
            await _productReop.UpdateAsync(product);
            scope.Complete();
        }
    }
}
