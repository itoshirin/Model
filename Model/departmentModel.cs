using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rolster 
{
    public class Department
    {
        public int Id { get; set; }

        public string name { get; set; } = default!;

        public string description { get; set; } = default!;

        public DateTime createDate { get; set; }

        public bool status { get; set; }
    }
}