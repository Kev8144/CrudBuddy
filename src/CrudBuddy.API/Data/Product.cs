using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CrudBuddy.API.Data;

public partial class Product
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public int StockQuantity { get; set; }

    [Column(TypeName = "DATETIME")]
    public DateTime? CreatedAt { get; set; }
}
