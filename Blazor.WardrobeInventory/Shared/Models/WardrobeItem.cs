using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Blazor.WardrobeInventory.Shared.Models;

public class WardrobeItem
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "Shirt/Jeans/Jacket/...")]

    public string Type { get; set; }
    [Display(Name = "Item Color")]
    public string Color { get; set; }
    public string ImagePath { get; set; }
}
