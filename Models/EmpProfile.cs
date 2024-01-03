using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project1Phase3.Models
{
    [Table("EmpProfile")]
    public class EmpProfile
    {
        [Key]
        public int EmpCode { get; set; }
        public string? EmpName { get; set; }
        public DateTime DOB { get; set; }
        public string? Email { get; set;}
        public int DeptMasterDeptCode { get; set;}
        public virtual DeptMaster DeptMaster { get; set; }
    }
}
