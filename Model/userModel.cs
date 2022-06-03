using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rolster
{
    public class User
    {
        public int ID { get; set; }

        public string fullName { get; set; } = default!;

        public DateTime createDate { get; set; }

        public bool status { get; set; }

        public string phone { get; set; } = default!;

        public string email { get; set; } = default!;

        public string address { get; set; } = default!;

        public string gender { get; set; } = default!;

        public string DoB { get; set; } = default!;

        public string avatar { get; set; } = default!;

        public string description { get; set; } = default!;

        public virtual List<SalaryHistoy> SalaryHistoys { get; set; } = default!;

        public virtual List<Review> Reviews { get; set; } = default!;

        public virtual List<LeaveApplication> LeaveApplications {get;set;} = default!;
        
    }

    public class SalaryHistoy
    {
        public int Id { get; set; }

        public DateTime createDate { get; set; }

        public DateTime applyDate { get; set; }

        public int userID { get; set; }

        public double salary { get; set; }

        public double allowance { get; set; }

        public string reason { get; set; } = default!;

        [ForeignKey("userID")]
        public virtual User user { get; set; } = default!;
    }

    public class Review
    {
        public int Id { get; set; }

        public DateTime createDate { get; set; }

        public int userID { get; set; }

        public int rate { get; set; }

        public string content { get; set; } = default!;

        [ForeignKey("userID")]
        public virtual User user { get; set; } = default!;
    }

    public class LeaveApplication
    {
        public int Id { get; set; }

        public DateTime createDate { get; set; }

        public int userID { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public string reason { get; set; } = default!;

        public bool status { get; set; }

        [ForeignKey("userID")]
        public virtual User user { get; set; } = default!;
    }
}