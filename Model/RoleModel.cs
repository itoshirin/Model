using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;


namespace rolster
{
    public class Role : IdentityRole
    {
        override public string Id { get; set; } = default!;
        override public string Name { get; set; } = default!;

        public DateTime CreateDate { get; set; }

        public bool Status { get; set; }

        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; } = default!;
    }

    public class UseRole
    {
        [Key]
        public int UserId { get; set; }

        [Key]
        public int RoleId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; } = default!;

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; } = default!;
    }

    public class RoleClaims
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public DateTime CreateDate { get; set; }

        public bool Status {get; set;}

        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; } = default!;
    }
}