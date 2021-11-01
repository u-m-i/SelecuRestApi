using System;
using System.Collections;

namespace Catalog.Entities
{
    public record Item
    {
        public Guid Id {get; init;}
        public string Name { get; init;}
        public string Material {get; init;}
        public decimal Price {get; init;}
        public decimal Power {get; init;}
        public DateTimeOffset CreatedDate { get; init;}

    }
}