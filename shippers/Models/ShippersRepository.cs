using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shippers.Models
{
    public class ShippersRepository : IShippersRepository
    {
        private NorthwindEntities db = new NorthwindEntities();

        public void Delete(Shippers shippers)
        {
            db.Shippers.Remove(shippers);
            db.SaveChanges();
        }

        public IEnumerable<Shippers> GetAll()
        {
            return db.Shippers.ToList();
        }

        public Shippers GetOne(int id)
        {
            return db.Shippers.Find(id);
        }

        public void Insert(Shippers shippers)
        {
            db.Shippers.Add(shippers);
            db.SaveChanges();
        }

        public void Update(Shippers shippers)
        {
            db.Entry(shippers).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}