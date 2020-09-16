using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public class Depot
    {
      [Key]
      public int DepotId { get; set; }
        
    }
}
