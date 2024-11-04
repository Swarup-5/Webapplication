using System.ComponentModel.DataAnnotations;
namespace Webapplication.Data.Entity
{
    public class Signuptable
    {
        [Key]

        public int Id { get; set; } 

        public string FistName { get; set; }

        public string LastName { get; set; }

        public int age { get; set; }    
        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Course { get; set; }

        public string Userstatus { get; set; }
        public bool isActive  { get; set; } 

        public string imagepath { get; set; }
    }
}
