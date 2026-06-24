using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public string PhotoUrl { get; private set; } = null!;
    public decimal Price { get; private set; } 
    public Guid ProductBrandId { get; set; }
    public ProductBrand ProductBrand { get; private set; } = null!;
    public Guid ProductTypeId { get; set; }
    public ProductType ProductType { get; private set; } = null!;
}
