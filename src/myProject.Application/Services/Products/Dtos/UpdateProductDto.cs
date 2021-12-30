﻿using System;
using System.Collections.Generic;
using System.Text;

namespace myProject.Services.Products.Dtos
{
    public class UpdateProductDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
    }
}
