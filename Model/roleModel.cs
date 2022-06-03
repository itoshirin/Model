using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rolster
{
    public class Role
    {
        public int Id { get; set; }
        public string name { get; set; } = default!;

        public DateTime createDate { get; set; }

        public bool status { get; set; }

        public int departmentId { get; set; }

        [ForeignKey("departmentId")]
        public virtual Department department { get; set; } = default!;
    }

    public class UseRole
    {
        [Key]
        public int userId { get; set; }

        [Key]
        public int roleId { get; set; }

        [ForeignKey("userId")]
        public virtual User user { get; set; } = default!;

        [ForeignKey("roleId")]
        public virtual Role role { get; set; } = default!;
    }

    public class RoleClaims
    {
        public int Id { get; set; }

        public string name { get; set; } = default!;

        public DateTime createDate { get; set; }

        public bool status { get; set; }

        public int departmentId { get; set; }

        [ForeignKey("departmentId")]
        public Department Department { get; set; } = default!;
    }
}