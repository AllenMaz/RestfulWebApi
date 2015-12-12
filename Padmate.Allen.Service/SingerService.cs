using Padmate.Allen.Dao;
using Padmate.Allen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padmate.Allen.Service
{
    public class SingerService
    {
        SingerDao dao = new SingerDao();

        public SingerService()
        {

        }

        public void Add(Singer singer)
        {
           dao.Create(singer);
        }

        public List<Singer> SearchAll()
        {
            List<Singer> singers = dao.Search();
            return singers;
        }

        public Singer SearchById(int id)
        {
            Singer singer = dao.SearchByID(id);
            return singer;
        }

        public void Edit(Singer singer)
        {
            dao.Edit(singer);
        }

        public void Delete(int id)
        {
            dao.Delete(id);
        }
    }
}
