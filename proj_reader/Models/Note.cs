using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_reader.Models
{
    [Table("Note")]
    public class Note
    {
        [Key]
        public int ID { set; get; }
        public string filePath { set; get; }

        public string note { set; get; }

        public DateTime? publishAt { set; get; }        
    }
}
