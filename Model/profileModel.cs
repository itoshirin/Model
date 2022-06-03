using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rolster
{
    public class Profile
    {
        public int Id { get; set; }

        public string name { get; set; } = default!;

        public int userID { get; set; } = default!;

        public DateTime createDate { get; set; }

        [ForeignKey("userID")]
        public virtual User user { get; set; } = default!;
    }

    public class Attachment 
    {
        public int Id {get;set;}

        public string name {get;set;} = default!;

        public string type {get;set;} = default!;

        public int size {get; set;}

        public string url {get;set;} = default!;

        public string ext {get;set;} = default!;

        public DateTime createDate {get;set;}
        
    }

    public class ProfileAttachment
    {
        [Key]
        public int profileId {get;set;}

        [Key]
        public int attachmentId {get;set;}

        [ForeignKey("profileId")]
        public virtual Profile Profile {get;set;} = default!;

        [ForeignKey("attachmentId")]
        public virtual List<Attachment> Attachments {get;set;} = default!;
    }
}