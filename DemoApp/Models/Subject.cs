using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        [Column(TypeName = "nvarchar(4)")]
        [RegularExpression("^[0-9]*$")]
        [StringLength(4, MinimumLength = 4)]
        [Required(ErrorMessage = "Subject number field is required !")]
        [DisplayName("Subject Number")]
        public string SubjectNumber { get; set; }

        [Column(TypeName = "nvarchar(6)")]
        public string Gender { get; set; }

        [Column("DoB", TypeName = "DateTime2")]
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        [RegularExpression("^[0-9]*$")]
        [StringLength(5, MinimumLength = 5)]
        [Required(ErrorMessage = "Site number field is required !")]
        [DisplayName("Site Number")]
        public string SiteNumber { get; set; }
    }
}
