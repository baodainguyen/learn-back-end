using strategy.DAL;
using System.Collections.Generic;
using System.Linq;

namespace strategy.BLL
{
    public class BaseBO<C, T> 
        where C : BaseContext<T>
        where T : class
    {   
        public List<T> GetAll()
        {
            var datas = new List<T>();
            using (var c = new BaseContext<T>())
            {
                datas = c.DbSets.ToList();
            }
            return datas;
        }

        public int Update(T item)
        {
            using var c = new BaseContext<T>();
            c.Update(item);
            return c.SaveChanges();
        }
        public int Delete(T item)
        {
            // TODO: check Role
            using var c = new BaseContext<T>();
            c.Remove(item);
            return c.SaveChanges();
        }
        public int Add(T item)
        {
            using var c = new BaseContext<T>();
            c.DbSets.Add(item);
            //c.Add<T>(item);
            return c.SaveChanges();
        }

        public void AddRange(List<T> items)
        {
            using var c = new BaseContext<T>();
            c.DbSets.AddRange(items);
            //c.AddRange(items);
            c.SaveChanges();
        }
    }
}
