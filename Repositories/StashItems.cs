// name spaces
using System;
using System.Linq;
using Catalog.Entities;
using System.Collections;
using System.Collections.Generic;


namespace Catalog.Repositories
{
    public class StashItem
    {
        private readonly List<Item> items = new()
        {
            new Item {Id = Guid.NewGuid(), Name = "Sword",Material = "Wood", Price = 6, Power = 4, CreatedDate = DateTimeOffset.UtcNow},
            new Item {Id = Guid.NewGuid(), Name = "Sword",Material = "Iron", Price = 12, Power = 9, CreatedDate = DateTimeOffset.UtcNow},
            new Item {Id = Guid.NewGuid(), Name = "Staff",Material = "Wood", Price = 7, Power = 6, CreatedDate = DateTimeOffset.UtcNow},
            new Item {Id = Guid.NewGuid(), Name = "Staff",Material = "Stone", Price = 15, Power = 14, CreatedDate = DateTimeOffset.UtcNow},
        };

        public IEnumerable<Item> GetSet() 
        {
            return items;

        }

        public Item GetSingle(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }
    }
}