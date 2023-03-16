using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blazor.WardrobeInventory.Shared.Models;

namespace Blazor.WardrobeInventory.Server.Data
{
    public class BlazorWardrobeInventoryServerContext : DbContext
    {
        public BlazorWardrobeInventoryServerContext (DbContextOptions<BlazorWardrobeInventoryServerContext> options)
            : base(options)
        {
        }

        public DbSet<Blazor.WardrobeInventory.Shared.Models.WardrobeItem> WardrobeItem { get; set; } = default!;
    }
}
