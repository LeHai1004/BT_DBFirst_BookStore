using System;
using System.Collections.Generic;

namespace BookStoreApp.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public decimal Price { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}
