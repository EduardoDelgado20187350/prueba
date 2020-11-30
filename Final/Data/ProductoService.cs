using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Data
{
    public class ProductoService
    {
        private readonly ApplicationDbContext dbContext;

        public ProductoService(ApplicationDbContext db)
        {
            dbContext = db;
        }
        public List<Producto> GetProductos()
        {
            var emplist = dbContext.productos.ToList();
            return emplist;
        }
        public string Create(Producto producto)
        {
            dbContext.productos.Add(producto);
            dbContext.SaveChanges();
            return "Save Successfully";
        }
        public Producto GetProductoById(int id)
        {
            Producto producto = dbContext.productos.FirstOrDefault(s => s.IdProducto == id);
            return producto;
        }
        public string UpdateProducto(Producto producto)
        {
            dbContext.productos.Update(producto);
            dbContext.SaveChanges();
            return "Update Successfully";
        }
        public string DeleteProdcuto(Producto producto)
        {
            dbContext.productos.Remove(producto);
            dbContext.SaveChanges();
            return "Delete Successfully";
        }
    }
   
    
}
