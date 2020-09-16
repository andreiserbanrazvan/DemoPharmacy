using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.Models
{
    public class Site
    {
        [Key]
        public int SiteId { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        [RegularExpression("^[0-9]*$")]
        [StringLength(5,MinimumLength=5)]
        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Site Number")]
        public string SiteNumber { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Address { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Site Doctor")]
        public string SiteDoctor { get; set; }
        
        [DisplayName("Medication Units")]
        public ICollection<Unit> MedicationUnits { get; set; }
    }
}
