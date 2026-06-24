using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Domain.Entities;

public class ProductType : BaseEntity
{
    public string Name { get; private set; } = null!;
    public ICollection<Product> Products { get; private set; } = [];

}
