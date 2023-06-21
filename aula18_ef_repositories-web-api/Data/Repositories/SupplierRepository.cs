using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_test.Data;
using aula12_ef_test.Domain;
using aula14_ef_repositories.Domain.Interfaces;

namespace aula14_ef_repositories.Data.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly DataContext context;

        public SupplierRepository()
        {
            this.context = new DataContext();
        }

        public void Delete(int entityId)
        {
            var p = GetById(entityId);
            context.Suppliers.Remove(p);
            context.SaveChanges();
        }

        public IList<Supplier> GetAll()
        {
            return context.Suppliers.ToList();
        }

        public Supplier GetById(int entityId)
        {
            return context.Suppliers.SingleOrDefault(x=>x.Id == entityId);
        }

        public void Save(Supplier entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Supplier entity)
        {
            context.Suppliers.Update(entity);
            context.SaveChanges();
        }
    }
}