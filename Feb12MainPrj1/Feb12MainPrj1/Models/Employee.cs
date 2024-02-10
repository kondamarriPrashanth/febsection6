using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feb12MainPrj1.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmpCode {  get; set; }
        public DateTime DateOfBirth { get; set; }
        //[StringLength(100)]
        public string EmpName {  get; set; }
      //  public string Email {  get; set; }
        public int DeptCode {  get; set; }
    }
}
