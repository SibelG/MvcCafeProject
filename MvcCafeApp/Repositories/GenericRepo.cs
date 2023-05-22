using Restaurant_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.DynamicData;

namespace Restaurant_Project.Repositories
{
    public class GenericRepo<T> where T : class, new()
    {
        DataContext db = new DataContext();
        public List<T> List()
        {
            return db.Set<T>().ToList();
        }
        public void Tadd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }
        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }
        public void TUpdate(T p)
        {
            db.Set<T>().AddOrUpdate(p);
            db.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }
    }
}