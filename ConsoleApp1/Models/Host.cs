using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp1.Models
{    
    ///[Table("MyHost")]
   public class Host
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
