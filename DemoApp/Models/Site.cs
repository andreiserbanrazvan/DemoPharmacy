using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Models
{
    public class Site
    {
        [Key]
        public int SiteId { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        [RegularExpression("^[0-9]*$")]
        [StringLength(5,MinimumLength=5)]
        [Required(ErrorMessage = "Site number field is required !")]
        [DisplayName("Site Number")]
        public string SiteNumber { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Address { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Site Doctor")]
        public string SiteDoctor { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [RegularExpression("^(([0-9]+,)*[0-9]+){6,6}$")]
        [StringLength(600, MinimumLength = 6)]
        [DisplayName("Medication Units")]
        public string MedicationUnits { get; set; }
    }
}
