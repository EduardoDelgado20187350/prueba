using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Data
{
    public class ProductoServicio2
    {

        private readonly ApplicationDbContext dbContext;

        public ProductoServicio2(ApplicationDbContext db)
        {
            dbContext = db;
        }
        public List<Servicio> GetServicio()
        {
            var emplist = dbContext.servicios.ToList();
            return emplist;
        }
        public string Create(Servicio servi )
        {
            dbContext.servicios.Add(servi);
            dbContext.SaveChanges();
            return "Save Successfully";
        }
        public Servicio GetServicioById(int id)
        {
           Servicio servicio = dbContext.servicios.FirstOrDefault(s => s.IdServicio == id);
            return servicio;
        }
        public string UpdateServicio(Servicio servi)
        {
            dbContext.servicios.Update(servi);
            dbContext.SaveChanges();
            return "Update Successfully";
        }
        public string DeleteServicio(Servicio servi)
        {
            dbContext.servicios.Remove(servi);
            dbContext.SaveChanges();
            return "Delete Successfully";
        }
    }



}
