using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext()) // for disposing (provides less memory usage)
            {
                return context.Products.ToList();

            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext()) // for disposing (provides less memory usage)
            {
                //context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext()) // for disposing (provides less memory usage)
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }

        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext()) // for disposing (provides less memory usage)
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }
    }
}
