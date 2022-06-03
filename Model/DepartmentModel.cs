using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rolster 
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public DateTime CreateDate { get; set; }

        public bool Status { get; set; }
    }
}