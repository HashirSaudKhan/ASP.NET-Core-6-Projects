using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudCFASP.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Column("StudentName", TypeName = "varchar(100)")]
        [Required]
        public string Name { get; set; }

        [Column("StudentGender", TypeName = "varchar(20)")]
        [Required]
        public string Gender { get; set; }

        [Required]
        public int Age { get; set;}
    }
}
