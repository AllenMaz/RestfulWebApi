using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padmate.Allen.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "专辑名称不能为空")]
        public string Name { get; set; }

        public DateTime IssueDate { get; set; }

        public Singer Singer { get; set; }


        List<Song> Song { get; set; }
    }
}
