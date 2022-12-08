using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnMVCUsingEFCodeFirst_Demo2.Entties
{
    [Table("Project")]
    public class Project
    {
        [StringLength(5)]
        [Column(TypeName ="char")]
        [Key] //set primary key
        public string ProjectCode { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string ProjectName { get; set; }
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }
    }
}
