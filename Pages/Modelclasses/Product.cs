﻿using System.ComponentModel.DataAnnotations;

namespace Webapplication.Pages.Modelclasses
{
    public class Product
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Price { get; set; } 
        public int Quantity { get; set; }

        public bool Is_active { get; set; }

    }
}
