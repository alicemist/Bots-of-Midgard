using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace wa01.Models;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public int Price { get; set; }

    public int? Quantity { get; set; }

    [JsonIgnore]
    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;
}
