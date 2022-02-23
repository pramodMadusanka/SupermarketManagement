﻿using System.ComponentModel.DataAnnotations;

namespace CoreBusiness;
public class Category
{
    [Key]
    public int CategoryId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
}
