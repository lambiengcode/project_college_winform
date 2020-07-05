using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_reader.Models
{
    [Table("Link")]
    public class Link
    {
        [Key]
        public int ID { set; get; }
        public string kind { set; get; }

        public string note { set; get; }
    }
}
