using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SampleNLayerProject.API.DTOs
{
    public class CategoryS
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }

    public class CategoryL : CategoryS
    {
    }
}