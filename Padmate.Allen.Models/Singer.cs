using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padmate.Allen.Models
{
    public class Singer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public List<Album> Albums { get; set; }
    }
}
