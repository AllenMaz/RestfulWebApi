using Padmate.Allen.Models;
using Padmate.Allen.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Padmate.Allen.RestfulWebApi.Controllers
{
    public class SingerController:ApiController
    {
        SingerService singerService = new SingerService();
        public IEnumerable<Singer> Get()
        {
            return singerService.SearchAll();

        }

        // GET: api/Singer/5
        public Singer Get(string name)
        {

            var singer = singerService.SearchAll().Where(v => v.Name.Contains(name)).FirstOrDefault();
            return singer;
        }

        // POST: api/Singer
        public void Post(Singer singer)
        {
            singerService.Add(singer);
        }

        // PUT: api/Singer/5
        public void Put(Singer singer)
        {
            singerService.Edit(singer);
        }

        // DELETE: api/Singer/5
        public void Delete(int Id)
        {
            singerService.Delete(Id);
        }



    }
}