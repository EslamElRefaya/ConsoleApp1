using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

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
