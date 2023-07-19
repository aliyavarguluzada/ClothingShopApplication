﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShopApplication.Models
{
    public class CategoryGender
    {
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public int GenderId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public Gender Gender { get; set; }
    }
}
