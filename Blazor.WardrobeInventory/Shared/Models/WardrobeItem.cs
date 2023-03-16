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
    public string Type { get; set; }
    public string Color { get; set; }
    public string ImgData { get; set; }
}
