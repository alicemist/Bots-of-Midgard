using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace wa01.Models;

public partial class Category
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
