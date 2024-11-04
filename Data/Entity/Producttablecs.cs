using System.ComponentModel.DataAnnotations;

namespace Webapplication.Data.Entity
{
    public class Producttablecs
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public int Quantity { get; set; }

        public string Category { get; set; }

        public bool IsActive { get; set; }

        
        
    }
}
