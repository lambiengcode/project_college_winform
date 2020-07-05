using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_reader.Models
{
    [Table("Kind")]
    public class Kind
    {
        [Key]
        public int ID { set; get; }
        public string kind { set; get; }        
    }
}
