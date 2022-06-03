using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace rolster
{
    public class User : IdentityUser
    {

        public int ID { get; set; }

        public string FullName { get; set; } = default!;

        public DateTime CreateDate { get; set; }

        public bool Status { get; set; }

        public string Phone { get; set; } = default!;

        override public string Email { get; set; } = default!;

        public string Address { get; set; } = default!;

        public string Gender { get; set; } = default!;

        public string DoB { get; set; } = default!;

        public string Avatar { get; set; } = default!;

        public string Description { get; set; } = default!;

        public virtual List<SalaryHistoy> SalaryHistoys { get; set; } = default!;

        public virtual List<Review> Reviews { get; set; } = default!;

        public virtual List<LeaveApplication> LeaveApplications {get;set;} = default!;
        
    }

    public class SalaryHistoy
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ApplyDate { get; set; }

        public int UserID { get; set; }

        public double Salary { get; set; }

        public double Allowance { get; set; }

        public string Reason { get; set; } = default!;

        [ForeignKey("UserID")]
        public virtual User User { get; set; } = default!;
    }

    public class Review
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public int UserID { get; set; }

        public int Rate { get; set; }

        public string Content { get; set; } = default!;

        [ForeignKey("UerID")]
        public virtual User User { get; set; } = default!;
    }

    public class LeaveApplication
    {
        public int Id { get; set; }

        public DateTime CreateDate { get; set; }

        public int UserID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Reason { get; set; } = default!;

        public bool Status { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; } = default!;
    }
}