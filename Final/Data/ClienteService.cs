using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Data
{
    public class ClienteService
    {
        private readonly ApplicationDbContext dbContext;

        public ClienteService(ApplicationDbContext db)
        {
            dbContext = db;
        }
        public List<ClienteFinal> GetClientes()
        {
            var emplist = dbContext.ClienteFinal.ToList();
            return emplist;
        }
        public string Create(ClienteFinal cliente)
        {
            dbContext.ClienteFinal.Add(cliente);
            dbContext.SaveChanges();
            return "Save Successfully";
        }
        public ClienteFinal GetClienteById(int id)
        {
            ClienteFinal cliente = dbContext.ClienteFinal.FirstOrDefault(s => s.Cliente_Id == id);
            return cliente;
        }
        public string UpdateCliente(ClienteFinal cliente)
        {
            dbContext.ClienteFinal.Update(cliente);
            dbContext.SaveChanges();
            return "Update Successfully";
        }
        public string DeleteCliente(ClienteFinal cliente)
        {
            dbContext.ClienteFinal.Remove(cliente);
            dbContext.SaveChanges();
            return "Delete Successfully";
        }
    }
}

