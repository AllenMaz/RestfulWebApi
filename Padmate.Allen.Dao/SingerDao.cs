using Padmate.Allen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padmate.Allen.Dao
{
    public class SingerDao
    {
        DBContext dbContext = new DBContext();

        public void Create(Singer singer)
        {
            dbContext.Singer.Add(singer);
            dbContext.SaveChanges();

        }

        public List<Singer> Search()
        {
            List<Singer> result = dbContext.Singer.ToList();
            return result;
        }

        public Singer SearchByID(int id)
        {
            Singer result = dbContext.Singer.Find(id);
            return result;
        }

        public void Edit(Singer singer)
        {
            
            dbContext.Entry(singer).State = System.Data.EntityState.Modified;
            dbContext.SaveChanges();
            
        }

        public void Delete(int id)
        {
            Singer singer = dbContext.Singer.Find(id);
            dbContext.Singer.Remove(singer);
            dbContext.SaveChanges();
        }

    }
}
