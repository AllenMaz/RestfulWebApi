using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padmate.Allen.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Singer { get; set; }

        public decimal DurationTime { get; set; }

        public Album Album { get; set; }
    }
}
