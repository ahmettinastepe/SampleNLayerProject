﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SampleNLayerProject.Core.Entities
{
    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}