using Dapper;
using productWebApi.Context;
using productWebApi.Entity;

namespace productWebApi.Models
{
    public class ProductRepository
    {
        public List<Product> GetProductionList()
        {
            return DbContext.connection.Query<Product>("Select * from Product").ToList();
        }
        public List<Product> GetProductionList(int Id)
        {
            return DbContext.connection.Query<Product>($"Select * from Product where Id ={Id}").ToList();
        }
        public int AddProduct(Product product)
        {


            int i = DbContext.connection.Execute($@"
            insert into Product 
            (
            ProductName,
            ProductPrice,
            ProductCategoryId
            ) 
            values 
            (
            '{product.ProductName}',
             {product.ProductPrice},
            '{product.ProductCategoryId}'
            )");
            return i;
        }
        public int UpdateProduct(Product product)
        {
            int i = DbContext.connection.Execute($@"
            Update Product SET 
            ProductName = '{product.ProductName}',
            ProductPrice = {product.ProductPrice},
            ProductCategoryId = {product.ProductCategoryId}
            where Id = {product.Id}");
            return i;
        }
        public int DeleteProduct(Product product)
        {
            int i = DbContext.connection.Execute($@"Delete from Product where Id = {product.Id}");
            return i;
        }
    }
}