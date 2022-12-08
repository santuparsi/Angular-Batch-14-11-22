using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnMVCUsingEFCodeFirst_Demo2.Entties
{
    [Table("Employee")]
    public class Employee
    {
        //Scalar properties(use to define columns in a table)
        [Key] //set a primary key
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //disable the identity
        public int EmployeeId { get; set; }
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string EmployeeName { get; set; }
        [StringLength(5)]
        [Column(TypeName = "char")]
        [ForeignKey("Project")]
        public string? ProjectCode { get; set; }
        //Navigation properties(use to make the foreign key relation)
        public Project Project { get; set; }
    }
}
