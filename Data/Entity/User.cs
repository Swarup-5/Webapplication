﻿using System.ComponentModel.DataAnnotations;

namespace Webapplication.Data.Entity
{
    public class User
    {
        [Key]

        public int Id { get; set; }

        [Required, MaxLength(100)]

        public  string Name { get; set; }

        [Required, MaxLength(100)]
        public  string Email { get; set; }

    }
}
