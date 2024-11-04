using System.ComponentModel.DataAnnotations;

namespace Webapplication.Data.Entity
{
    public class Logintable
    {
        [Key]

        public int Id { get; set; }

        //public string Name { get; set; }

        public string Email { get; set; } 

        public string Password { get; set; }

        //public string Message { get; set; }
    }
}
