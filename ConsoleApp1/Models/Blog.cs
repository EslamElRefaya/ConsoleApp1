using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Models
{
    public class Blog
    {
        public int ID { get; set; }
        
        public string URL { get; set;  }

        [NotMapped]
        public List<Host> Hosts { get; set; }
    }
}
